using FarPoint.Win.Spread;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using pdfViewer.Class;
using pdfViewer.Class.clsNode;
using pdfViewer.Class.clsPdf;
using pdfViewer.Class.clsQuery;
using pdfViewer.Class.data;
using pdfViewer.Class.pdfCode;
using pdfViewer.frm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfViewer
{
    public partial class frmMain : Form
    {
        #region Tag
        private const string _Code = "Code";
        private const string _Name = "Name";
        private const string _pdfCode = "pdfCode";
        private const string _Page = "Page";
        #endregion
        private MysqlController myCon;
        public SheetView sv
        {
            get
            {
                return Manager.sv;
            }
        }
        private bool myLoadChecked;
        private void SetTvimage()
        {
            Manager.SetTvImageClear();
            Image[] image = clsNodeController.GetImages();
            Manager.SetTvImageAdd(image);
        }
        public frmMain()
        {
            InitializeComponent();
            ExtensionSource.myCon = new MysqlController();
            myCon = ExtensionSource.myCon;
        }
        private string Gubun;

        private void frmMain_Resize(object sender, EventArgs e)
        {
            var w = this.Width - (33 + exPnl.Width);
            exPnl.Location = new Point(w, 1);
            var addrLocation = Manager.GettxtAddrLocation();
            bar.Location = new Point(0, addrLocation.Y);
        }

        private void ExpandablePanel1_SizeChanged(object sender, EventArgs e)
        {
            var w = ExpandablePanel1.Width;
            pdf.Location = new Point(w, 0);
            pdf.Size = new Size(this.Width - w, this.Height);
        }

        private void Manager_ChangeIndexCmbGubun(object sender, EventArgs e)
        {
            try
            {
                Manager.SetEnable(false);
                myLoadChecked = true;
                ExtensionSource.Gubun = Strings.Left(sender.ToString(), 1);
                Gubun = ExtensionSource.Gubun;
                var frm = new frmServer();
                frm.ShowDialog();
                if (frm.MysqlConChecked)
                {                    
                    SetTvimage();
                    SetNodeLoad();
                    Manager.SetSvRowCountClear();
                    Manager.LabelEdit = false;
                    SetPdfOpen();
                    this.Activate();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Manager.SetEnable(true);
        }
        private void SetNodeLoad()
        {
            Manager.SetTvNodeClear();
            Manager.SelectedNode = null;
            clsNodeController.Select.SetNodesSelect(Manager.GetetTvNode(), ref Manager.btnInsertChecked, true);
            Manager.SetTvBug_Block();
        }
        private void SetPdfOpen()
        {
            if (Gubun != "0")
                return;
            if (clsPdfController.GetFileExist(Application.StartupPath + @"\manual\e클릭설명서.pdf") == false)
            {
                clsPdfController.Save.GetDirectoryPath();
                Manager_PdfInsert();
            }
            if (clsPdfController.GetFileExist(Application.StartupPath + @"\manual\manualVersion.txt") == false)
            {
                clsPdfController.Save.GetDirectoryPath();
                Manager_PdfInsert();
            }
            if (pdf.DocumentFilePath == "")
                pdfLoad();
            SetSearchVisibleTick();
        }
        private void SetSearchVisibleTick()
        {
            var t = new Timer() { Enabled = true, Interval = 500 };
            t.Start();
            t.Tick += (s, e) =>
            {
                t.Stop();
                exPnl.Expanded = true;
            };
        }
        private void pdfLoad()
        {
            pdf.DocumentFilePath = Application.StartupPath + @"\manual\e클릭설명서.pdf";
        }

        private void Manager_Delete(object sender, EventArgs e)
        {
            var selectedNode = sender as TreeNode;
            string FullPath = selectedNode.FullPath;
            string nodeText = selectedNode.Text;
            var boolean = false;
            CheckMessage(FullPath, nodeText, ref boolean);
        }
        private void CheckMessage(string FullPath, string nodeText, [Optional, DefaultParameterValue(false)] ref bool CancelCheck, bool GitaEdition = true)
        {
            int index = 0;
            var result = clsNodeController.Delete.GetMessageResult(FullPath, nodeText, ref index);
            if (DialogResult.Yes == result)
            {
                clsNodeController.Delete.SetNodeDelete(FullPath, Manager.SelectedNode);
                if (GitaEdition)
                {
                    var newPath = clsNodeController.GetRemoveFullpath(FullPath, nodeText);
                    clsQueryController.UpdateTv.SetUpdateIndexAfterDelete(newPath, index);
                    Manager.SetTvNodeRemove();
                    Manager.SetClear(false);
                }
            }
            else
            {
                CancelCheck = true;
            }
        }
        private void Manager_FirstNodeSelect(object sender, EventArgs e)
        {
            var dT = clsQueryController.SelectTv.GetSelectFirstNode();
            int row = -1;
            foreach (DataRow dR in dT.Rows)
            {
                row += 1;
                var dup = Conversions.ToInteger(dR["tv_dup"]);
                int i = row != dup ? dup : row;
                sv.Cells[i, sv.Columns[_Code].Index].Value = dup + 1;
                sv.Cells[i, sv.Columns[_Name].Index].Value = dR["tv_name"];
                sv.Cells[row, sv.Columns[_pdfCode].Index].Value = dR["tv_Code"].ToString();
                var Page = Conversions.ToInteger(dR["tv_Page"].ToString());
                if (Page == 0)
                {

                    sv.Cells[row, sv.Columns[_Page].Index].Value = "";
                }
                else
                {
                    sv.Cells[row, sv.Columns[_Page].Index].Value = Page;
                }
            }
        }

        private void Manager_Insert(object sender, EventArgs e)
        {
            SetBarVisible(true);
            if (sender != null)
            {
                NodesInsert(sender as TreeNode);
            }
            else
            {
                FirstNodeInsert();
            }
        }
        private void FirstNodeInsert()
        {
            var nodeCollection = Manager.tv_manager.Nodes;
            SetNodesDelete(ref nodeCollection);
            SetFirstNodeSave(nodeCollection);
        }
        private void SetFirstNodeSave(TreeNodeCollection nodeCollection)
        {
            int auto = 0;
            var dataCellCount = sv.GetLastNonEmptyRow(NonEmptyItemFlag.Data);
            Manager.SetEnable(false);
            for (int i = 0, loopTo = sv.GetLastNonEmptyRow(NonEmptyItemFlag.Data); i <= loopTo; i++)
            {
                Application.DoEvents();
                var tv_name = sv.Cells[i, sv.Columns[_Name].Index].Value.ToString();
                if (clsNodeController.GetSprNameEmptyCheck(nodeCollection, tv_name, i))
                    goto delete;
                var findNode = clsNodeController.GetFindNode(nodeCollection, tv_name);
                int dup = Conversions.ToInteger(sv.Cells[i, sv.Columns[_Code].Index].Value.ToString()) - 1;
                string fileName = Strings.Trim(sv.Cells[i, sv.Columns[_pdfCode].Index].Value.ToString()).TrimEnd(Constants.vbCrLf.ToCharArray());
                if (!string.IsNullOrEmpty(fileName))
                {
                    if (clsCodeController.GetCodeChecked(fileName, tv_name))
                        goto delete;
                }
                int page = string.IsNullOrEmpty(fileName) ? 0 : clsPdfController.Select.GetCodePage(pdf.DocumentFilePath, fileName);
                if (page == -1)
                {
                    Interaction.MsgBox($"{_Code} :: 중복된 코드가 있거나 코드가 정확하지 않습니다..");
                    goto delete;
                }
                if (findNode is null)
                {
                    if (dup == -1)
                    {
                        clsQueryController.InsertTv.SetTVinsert(tv_name, fileName, i, page, ref auto);
                    }
                    else
                    {
                        // 수정 + index
                        SetFirstNodeModify(tv_name, fileName, dup, i, page, false, ref auto);
                    }
                }
                else
                {
                    // index
                    SetFirstNodeModify(tv_name, fileName, dup, i, page, true, ref auto);
                }
                SetBarValue(dataCellCount, i);
                delete:
                ;
            }
            Manager.SetEnable(true);
            clsQueryController.UpdateTv.SetUpdateIndexAfterDelete("", 0);
            SetNodeLoad();
            SetsvClear();
            SetBarVisible(false);
        }
        private void SetFirstNodeModify(string tv_name, string filename, int dup, int i, int page, bool updateonlyindex, [Optional, DefaultParameterValue(0)] ref int auto)
        {
            var dT = clsQueryController.SelectTv.GetSelectFirstNode(tv_name, dup, auto, updateonlyindex);
            clsNodeController.Editor.SetFirstNodeEdit(dT, tv_name, filename, dup, i, page, updateonlyindex, ref auto);
        }
        private void SetNodesDelete(ref TreeNodeCollection nodeCol)
        {
            bool delCancelCheck = false;
            string[] removeName = Manager.RemoveNodeNameList.ToArray();
            if (removeName.Length != 0)
            {
                foreach (var r in removeName)
                {
                    var childNode = clsNodeController.GetFindNode(nodeCol, r);
                    if (childNode is null)
                        goto here;
                    string path = r;
                    CheckMessage(path, r, ref delCancelCheck, false);
                    if (delCancelCheck)
                        goto here;
                    childNode.Remove();
                    here:
                    ;
                }
            }
        }
        private void NodesInsert(TreeNode node)
        {
            if (clsPdfController.pdfCodeChecked(sv))
            {
                Interaction.MsgBox("중복된 코드가 발견 되었습니다");
                return;
            }
            var idx = clsNodeController.Editor.UpdateDataBaseIndex(node.FullPath);
            SetNodesDelete(ref node);
            SetNodeSave(node, idx);
        }
        private void SetNodesDelete(ref TreeNode node)
        {
            bool delCancelCheck = false;
            string[] removeName = Manager.RemoveNodeNameList.ToArray();
            if (removeName.Length != 0)
            {
                foreach (var r in removeName)
                {
                    var childNode = clsNodeController.GetFindNode(node, r);
                    if (childNode is null)
                        goto here;
                    var path = node.FullPath + "|" + r;
                    CheckMessage(path, r, ref delCancelCheck, false);
                    if (delCancelCheck)
                        goto here;
                    node.Nodes.Remove(childNode);
                    if (node.Nodes.Count == 0)
                        Manager.ManagerTv_ImageIndex(node, 0);
                    here:
                    ;
                }
            }
        }
        private void SetNodeSave(TreeNode node, int idx)
        {
            int tv_auto = 0;
            var dataCellCount = sv.GetLastNonEmptyRow(NonEmptyItemFlag.Data);
            Manager.SetEnable(false);
            string where;
            for (int i = 0, loopTo = dataCellCount; i <= loopTo; i++)
            {
                Application.DoEvents();
                var tv_name = sv.Cells[i, sv.Columns[_Name].Index].Value.ToString();
                var childFullpath = node.FullPath + "|" + tv_name;
                if (clsNodeController.GetSprNameEmptyCheck(node, tv_name, i))
                    goto delete;
                var findNode = clsNodeController.GetFindNode(node, tv_name);
                string _code = Strings.Trim(sv.Cells[i, sv.Columns[_pdfCode].Index].Value.ToString()).TrimEnd(Constants.vbCrLf.ToCharArray());
                if (!string.IsNullOrEmpty(_code))
                {
                    if (clsCodeController.GetCodeChecked(_code, childFullpath))
                        goto delete;
                }
                int page = string.IsNullOrEmpty(_code) ? 0 : clsPdfController.Select.GetCodePage(pdf.DocumentFilePath, _code);
                if (page == -1)
                {
                    Interaction.MsgBox($"{_code} :: 중복된 코드가 있거나 코드가 정확하지 않습니다..");
                    goto delete;
                }
                int dup = Conversions.ToInteger(sv.Cells[i, sv.Columns[tag: _Code].Index].Value.ToString()) - 1;
                if (findNode is null)
                {
                    string sql = $"INSERT INTO tv(tv_gubun,tv_no,tv_name,tv_dup,tv_code,tv_page)VALUES";
                    sql += $"('{Gubun}',{idx},'{childFullpath}',{i},'{_code}',{page});";
                    where = $"tv_gubun = '{Gubun}' AND tv_no = {idx} AND tv_name LIKE '{node.FullPath + "|"}%' ";
                    if (node.Nodes.Count - 1 >= dup && dup >= -1)
                    {
                        where += $"AND tv_dup = {dup} AND tv_auto <> {tv_auto}";
                    }
                    else
                    {
                        where += $"AND tv_dup = {i} ";
                    }
                    // 추가부분 수정 완료
                    if (clsNodeController.Editor.GetDataUpdate(where, node.FullPath + "|", tv_name, i, page, _code, ref tv_auto, false) == false)
                    {
                        if (node.ImageIndex == 0)
                            Manager.ManagerTv_ImageIndex(node, 2);
                        myCon.My_EXECUTE(sql, ExtensionSource.DBname, ref tv_auto);
                    }
                }
                else if (findNode.Text == tv_name)
                {
                    // index 만 수정완료
                    if (node.Nodes.Count - 1 >= dup && dup > -1)
                    {
                        var childNodetxt = node.Nodes[dup].Text;
                        var newChildPath = node.FullPath + "|" + childNodetxt;
                        where = $@" (
    (tv_gubun = '{Gubun}' AND tv_no = {idx} AND tv_name = '{newChildPath}' AND tv_dup = {dup} AND tv_auto <> {tv_auto}) 
    OR 
    (tv_gubun = '{Gubun}' AND tv_no <> {idx} AND tv_name LIKE '{newChildPath}|%')
    ) 
    ORDER BY tv_no,tv_dup ASC";
                        clsNodeController.Editor.GetDataUpdate(where, node.FullPath + "|", tv_name, i, page, _code, ref tv_auto, true);
                    }
                }
                SetBarValue(dataCellCount, i);
                delete:
                ;
            }
            Manager.SetEnable(true);
            var getSelectedNode = node;
            clsQueryController.UpdateTv.SetUpdateIndexAfterDelete(node.FullPath + "|", idx);
            SetNodeLoad();
            var expandNode = Manager.tv_manager.Nodes.Find(getSelectedNode.Text, true);
            Manager.SelectedNode = expandNode[0];
            SetsvClear();
            clsNodeController.NodeExpand(Manager.SelectedNode);
            SetBarVisible(false);
        }
        private void SetsvClear()
        {
            sv.ClearRange(0, 0, sv.RowCount, sv.ColumnCount, true);
        }
        private void SetBarValue(int dataCellCount, int row)
        {
            float value = (float)(100d * (row / (double)dataCellCount));
            bar.EditValue = value;
        }
        private void SetBarVisible(bool boolean)
        {
            bar.Visible = boolean;
            bar.EditValue = 0;
        }

        private void Manager_MenuNodeModify(string Name, string pdfName)
        {
            clsCodeController.Editor.SetTvMenu_NameEdit(Manager.SelectedNode, Name, pdfName);
        }

        private void Manager_MenuNodeDel(object sender, EventArgs e)
        {
            var selectedNode = sender as TreeNode;
            string fullpath = selectedNode.FullPath;
            string nodeText = selectedNode.Text;
            TreeNode parentNode = selectedNode.Parent;
            string parentFullpath = parentNode is null ? "" : parentNode.FullPath;
            if (parentNode != null)
            {
                if (parentNode.Nodes.Count == 0)
                    Manager.ManagerTv_ImageIndex(parentNode, 0);
            }
            var boolean = false;
            CheckMessage(fullpath, nodeText, ref boolean);
        }

        private void Manager_MenuNodePdfDel(object sender, EventArgs e)
        {
            clsQueryController.Delete.GetPDFdelete(sender as string);
        }

        private void Manager_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MouseNodeClick(sender as string, e.Node);
        }
        private void MouseNodeClick(string fullPath, TreeNode selectedNode)
        {
            SetsvClear();
            var dT = clsQueryController.SelectTv.GetSelect_Node(fullPath);
            if (dT is null)
                return;
            int row = -1;
            foreach (DataRow dR in dT.Rows)
            {
                row += 1;
                var tv_name = clsNodeController.GetRemoveFullpath(dR["tv_name"].ToString(), fullPath + "|");
                sv.Cells[row, sv.Columns[_Code].Index].Value = Conversions.ToInteger(dR["tv_dup"].ToString()) + 1;
                sv.Cells[row, sv.Columns[_Name].Index].Value = tv_name;
                sv.Cells[row, sv.Columns[_pdfCode].Index].Value = dR["tv_Code"].ToString();
                var Page = Conversions.ToInteger(dR["tv_Page"].ToString());
                if (Page == 0)
                {
                    sv.Cells[row, sv.Columns[_Page].Index].Value = "";
                }
                else
                {
                    sv.Cells[row, sv.Columns[_Page].Index].Value = Page;
                }
            }
            if (dT.Rows.Count == 0)
            {
                sv.SetActiveCell(0, sv.Columns[_Name].Index);
                SetsvClear();
            }
        }

        private void Manager_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            PdfSelect(sender as string);
            Search1_TxtValueChanged();
        }
        private void PdfSelect(string tv_name)
        {
            var page = clsPdfController.Select.GetPDFpage(tv_name);
            if (page > 0)
                pdf.CurrentPageNumber = page;
        }
        private void Manager_pdfClose()
        {
            pdf.DocumentFilePath = "";
        }

        private void Manager_PdfInsert()
        {
            var openFile = new OpenFileDialog();
            var result = openFile.ShowDialog();
            if (DialogResult.OK == result)
            {
                var filePath = openFile.FileName;
                if (filePath == Application.StartupPath + @"\manual\e클릭설명서.pdf")
                {
                    Interaction.MsgBox("같은경로의 PDF를 다운받을 수 없습니다..");
                    return;
                }
                if (filePath == Application.StartupPath + @"\manual\manualVersion.txt")
                {
                    Interaction.MsgBox("같은경로의 version를 다운받을 수 없습니다..");
                    return;
                }
                var onlyFileName = Path.GetFileName(filePath);
                if (Manager.chkPdfCheck)
                {
                    SetBarVisible(true);
                    dataController.SetDataUpdate(bar, filePath);
                    SetBarVisible(false);
                }
                // clsPdfController.Save.SetUpload(filePath, onlyFileName)
                Manager_pdfClose();
                clsPdfController.Save.SetUpdate(filePath, onlyFileName);
                pdfLoad();
            }
        }

        private void Manager_pdfOpen()
        {
            var open = new OpenFileDialog() { FileName = string.Empty };
            var result = open.ShowDialog();
            if (result == DialogResult.OK)
                pdf.DocumentFilePath = open.FileName;
        }

        private void Manager_PdfUpdate()
        {
            var frm = new frmUpload();
            frm.Show();
        }

        private void Manager_Search(object sender)
        {
            var txtSearch = sender as string;
            SetNodeLoad();
            if (txtSearch == "")
            {
            }
            else
            {
                TreeNodeCollection nodeCollection = Manager.GetetTvNode();
                TreeNode[] selectedNode = clsNodeController.Search.NodeFild(nodeCollection, txtSearch);
                Manager.SetTvNodeClear();
                if (selectedNode[0] is null)
                    return;
                foreach (TreeNode node in selectedNode)
                    Manager.SetSelectedNodeCollection(node);
                MouseNodeClick(selectedNode[0].FullPath, selectedNode[0]);
                Manager.SelectedNode = selectedNode[0];
                Manager.SetNodeFullpath(selectedNode[0]);
            }
        }

        private void Manager_ToolPdfFileOpen(object sender, EventArgs e)
        {
            SetOpenCodeEdit();
        }
        private void SetOpenCodeEdit(bool SetToSpread = false)
        {
            var frm = new frmCodeList(Manager.SelectedNode, pdf.DocumentFilePath);
            frm.Show();
        }
        int nowPage;
        private void Search1_PageMove_withTxt(string txtSearch)
        {
            if (txtSearch != "" && pdf.DocumentFilePath != "")
            {
                var getpage = clsPdfController.Search.CheckedPage(txtSearch, pdf.DocumentFilePath,ref nowPage);
                if (getpage != 0)
                {
                    pdf.CurrentPageNumber = getpage;
                }
                else
                {
                    Interaction.MsgBox("일치하는 검색어가 없습니다..");
                }
            }
        }

        private void Search1_TxtValueChanged()
        {
            nowPage = 0;
        }
    }
}
