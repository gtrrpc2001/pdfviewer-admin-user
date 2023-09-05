using FarPoint.Win.Spread;
using Microsoft.VisualBasic;
using pdfViewer.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace pdfViewer.usercontrol
{
    public partial class pdfManager : UserControl
    {
        #region EVENT
        public event FirstNodeSelectEventHandler FirstNodeSelect;

        public delegate void FirstNodeSelectEventHandler(object sender, EventArgs e);
        public event InsertEventHandler Insert;

        public delegate void InsertEventHandler(object sender, EventArgs e);
        public event DeleteEventHandler Delete;

        public delegate void DeleteEventHandler(object sender, EventArgs e);
        public event SearchEventHandler Search;

        public delegate void SearchEventHandler(object sender);
        public event NodeMouseClickEventHandler NodeMouseClick;

        public delegate void NodeMouseClickEventHandler(object sender, TreeNodeMouseClickEventArgs e);
        public event NodeMouseDoubleClickEventHandler NodeMouseDoubleClick;

        public delegate void NodeMouseDoubleClickEventHandler(object sender, TreeNodeMouseClickEventArgs e);
        public event MenuNodeModifyEventHandler MenuNodeModify;

        public delegate void MenuNodeModifyEventHandler(string Name, string pdfName);
        public event MenuNodePdfDelEventHandler MenuNodePdfDel;

        public delegate void MenuNodePdfDelEventHandler(object sender, EventArgs e);
        public event MenuNodeDelEventHandler MenuNodeDel;

        public delegate void MenuNodeDelEventHandler(object sender, EventArgs e);
        public event ChangeIndexCmbGubunEventHandler ChangeIndexCmbGubun;

        public delegate void ChangeIndexCmbGubunEventHandler(object sender, EventArgs e);
        public event ToolPdfFileOpenEventHandler ToolPdfFileOpen;

        public delegate void ToolPdfFileOpenEventHandler(object sender, EventArgs e);
        public event SelectionCellDownEventHandler SelectionCellDown;

        public delegate void SelectionCellDownEventHandler(int startRow, int LastRow);
        public event SelectionCellUpEventHandler SelectionCellUp;

        public delegate void SelectionCellUpEventHandler(int startRow, int LastRow);
        public event PdfUpdateEventHandler PdfUpdate;

        public delegate void PdfUpdateEventHandler();
        public event PdfInsertEventHandler PdfInsert;

        public delegate void PdfInsertEventHandler();
        public event pdfOpenEventHandler pdfOpen;

        public delegate void pdfOpenEventHandler();
        public event pdfCloseEventHandler pdfClose;

        public delegate void pdfCloseEventHandler();
        #endregion
        #region 전역변수
        private Point M_DownPt;
        private bool _FirstNodeClick = false;
        public bool btnInsertChecked = false;
        #endregion
        #region Tag
        private const string _Code = "Code";
        private const string _Name = "Name";
        private const string _pdfCode = "pdfCode";
        #endregion
        #region Property
        public bool chkPdfCheck
        {
            get
            {
                return chkPdf.Checked;
            }
        }
        public SheetView sv
        {
            get
            {
                return spr_Sheet1;
            }
        }
        public bool LabelEdit
        {
            get
            {
                return tv_manager.LabelEdit;
            }
            set
            {
                tv_manager.LabelEdit = value;
            }
        }
        public string txtSearch
        {
            get
            {
                return txtGumsek.Text;
            }
        }
        public TreeNode SelectedNode
        {
            get
            {
                return tv_manager.SelectedNode;
            }
            set
            {
                tv_manager.SelectedNode = value;
                // If value Is Nothing Then sv.ClearRange(0, 0, sv.RowCount, sv.ColumnCount, True)
            }
        }
        public bool FirstNodeClick
        {
            get
            {
                return _FirstNodeClick;
            }
            set
            {
                _FirstNodeClick = value;
            }
        }
        #endregion
        #region Add
        public void SetTvNodeAdd(string item)
        {
            tv_manager.Nodes.Add(item);
        }
        public TreeNode GetTvNodeAdd(string item)
        {
            return tv_manager.Nodes.Add(item, item);
        }
        public void SetTvNodeAdd(string key, string item)
        {
            tv_manager.Nodes.Add(key, item);
        }
        public void SetTvNodeAdd(TreeNode TempNode)
        {
            tv_manager.Nodes.Add(TempNode);
        }

        public void SetTvImageAdd(Image[] Image)
        {
            tv_manager.ImageList.Images.AddRange(Image);
        }
        public void SetTvNodeAddRange(TreeNode[] nodes)
        {
            tv_manager.Nodes.AddRange(nodes);
        }
        public void SetTvSelectedNodeAdd(string item)
        {
            tv_manager.SelectedNode.Nodes.Add(item);
        }
        public void SetTvSelectedNodeAdd(string key, string item)
        {
            tv_manager.SelectedNode.Nodes.Add(key, item);
        }
        public void SetTvSelectedNodeAddRange(TreeNode[] nodes)
        {
            tv_manager.SelectedNode.Nodes.AddRange(nodes);
        }
        public void SetTvNodeInsert(int index, string item)
        {
            tv_manager.Nodes.Insert(index, item);
        }
        public void SetSelectedNodeCollection(TreeNode SelectedNode)
        {
            if (SelectedNode != null)
                tv_manager.Nodes.Add(SelectedNode);
        }
        public void SetSelectedNode(TreeNode SelectedNode)
        {
            tv_manager.SelectedNode = SelectedNode;
        }
        #endregion
        #region Clear
        public void SetTvImageClear()
        {
            tv_manager.ImageList.Images.Clear();
        }
        public void SetTvNodeClear()
        {
            tv_manager.Nodes.Clear();
        }
        public void SetTvNodeRemove()
        {
            if (tv_manager.SelectedNode.Level == 0)
                goto here;
            if (tv_manager.SelectedNode.Parent.Nodes.Count == 1)
                ManagerTv_ImageIndex(tv_manager.SelectedNode.Parent, 0);
            here:
            ;
            tv_manager.SelectedNode.Remove();
        }
        public void SetSvRowCountClear()
        {
            sv.ClearRange(0, 0, sv.RowCount, sv.ColumnCount, true);
            txtAddr.Text = string.Empty;
        }
        public void SetClear(bool @bool, bool SelectedNodeValue = false, bool CellClear = true)
        {
            if (SelectedNodeValue == false)
                tv_manager.SelectedNode = null;
            txtAddr.Text = string.Empty;
            if (CellClear)
                sv.ClearRange(0, 0, sv.RowCount, sv.ColumnCount, true);
            btnInsertChecked = @bool;
        }
        public List<string> RemoveNodeNameList = new List<string>();
        public List<int> AddCellList = new List<int>();
        private void ListClear()
        {
            RemoveNodeNameList.Clear();
            AddCellList.Clear();
        }
        #endregion
        #region Get
        public Point GettxtAddrLocation()
        {
            return txtAddr.Location;
        }
        public TreeNodeCollection GetetTvNode()
        {
            return tv_manager.Nodes;
        }
        public bool GetCmbGubunChecked()
        {
            if (cmbGubun.Text == string.Empty)
            {
                ListClear();
                SetClear(false);
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
        public void SetEnable(bool @bool)
        {
            cmbGubun.Enabled = @bool;
            tv_manager.Enabled = @bool;
            chkPdf.Enabled = @bool;
            txtGumsek.Enabled = @bool;
            spr.Enabled = @bool;
            btnPDFoption.Enabled = @bool;
            btnSearch.Enabled = @bool;
            btnReset.Enabled = @bool;
            btnFirstNodes.Enabled = @bool;
            btnUp.Enabled = @bool;
            btnDown.Enabled = @bool;
            btnInsert.Enabled = @bool;
            btnDelete.Enabled = @bool;
        }
        public pdfManager()
        {
            InitializeComponent();
            clsSpread.SpreadSetCursor(this);
            tv_manager.ImageList = new ImageList();
            tv_manager.ShowLines = false;
            tv_manager.Scrollable = true;
            tv_manager.ShowPlusMinus = false;
        }
        #region Load        
        private void _cmbGubun_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void _cmbGubun_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListClear();
            FirstNodeClick = false;
            ChangeIndexCmbGubun?.Invoke(cmbGubun.Text, e);
        }
        public void ManagerTv_ImageIndex(TreeNode node, int index)
        {
            node.ImageIndex = index;
            node.SelectedImageIndex = index;
        }
        #endregion
        private void _btnPDFopen_Click(object sender, EventArgs e)
        {
            pdfOpen?.Invoke();
        }

        private void _btnPDFclose_Click(object sender, EventArgs e)
        {
            pdfClose?.Invoke();
        }

        private void _txtGumsek_KeyDown(object sender, KeyEventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                tv_manager.preventExpand = false;
                FirstNodeClick = false;
                Search?.Invoke(txtGumsek.Text);
                SetSearchClear();
            }
        }
        private void SetSearchClear()
        {
            if (txtGumsek.Text == string.Empty)
            {
                sv.ClearRange(0, 0, sv.RowCount, sv.ColumnCount, true);
                txtAddr.Text = string.Empty;
            }
        }

        private void _btnSearch_Click(object sender, EventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            tv_manager.preventExpand = false;
            FirstNodeClick = false;
            ListClear();
            Search?.Invoke(txtGumsek.Text);
            SetSearchClear();
        }

        private void _btnInsert_Click(object sender, EventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            if (sv.Cells[0, sv.Columns["Name"].Index].Value is null)
                return;
            Insert?.Invoke(tv_manager.SelectedNode, e);
            SetTvBug_Block();
            ListClear();
            SetClear(false, CellClear: false);
        }
        public void SetTvBug_Block()
        {
            tv_manager.BeginUpdate();
            tv_manager.EndUpdate();
        }

        private void _btnPdfUpload_Click(object sender, EventArgs e)
        {
            PdfUpdate?.Invoke();
        }

        private void _btnPDFInsert_Click(object sender, EventArgs e)
        {
            PdfInsert?.Invoke();
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            if (tv_manager.SelectedNode is null)
            {
                MessageBox.Show("삭제 할 node를 선택해 주세요");
                return;
            }
            Delete?.Invoke(tv_manager.SelectedNode, e);
        }

        private void _btnReset_Click(object sender, EventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            if (FirstNodeClick == false & tv_manager.SelectedNode != null)
            {
                var NodeClickEv = new TreeNodeMouseClickEventArgs(tv_manager.SelectedNode, MouseButtons.Left, 1, 0, 0);
                NodeMouseClick?.Invoke(tv_manager.SelectedNode.FullPath, NodeClickEv);
            }
            else if (FirstNodeClick)
            {
                _btnFirstNodes_Click(default, e);
            }
            ListClear();
        }

        private void _btnFirstNodes_Click(object sender, EventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            ListClear();
            SetClear(true);
            FirstNodeSelect?.Invoke(sender, e);
            FirstNodeClick = true;
        }

        private void _btnUp_Click(object sender, EventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            if ((sv.Cells[sv.ActiveRowIndex, sv.Columns[_Name].Index].Value == null | SelectedNode is null) & btnInsertChecked == false)
                return;
            SetUpDown(false);
        }

        private void _btnDown_Click(object sender, EventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            if ((sv.ActiveRowIndex == sv.RowCount - 1 | sv.Cells[sv.ActiveRowIndex, sv.Columns[_Name].Index].Value == null | SelectedNode is null) & btnInsertChecked == false)
                return;
            SetUpDown(true);
        }
        Point M_UpPt;
        private void SetUpDown(bool Down)
        {
            int startRow = sv.ActiveRowIndex;
            FarPoint.Win.Spread.Model.CellRange[] DragCell = sv.GetSelections();
            if (DragCell.Length == 0)
                return;
            var ColIndex = DragCell[0].Column;
            int Col = DragCell.Length == 0 ? 0 : DragCell[0].ColumnCount;
            int row = DragCell.Length == 0 ? 1 : DragCell[0].RowCount;
            int lastRow = M_UpPt.Y < M_DownPt.Y ? startRow - (row - 1) : startRow + (row - 1);
            int decideFromIndex = lastRow < startRow ? startRow - (row - 1) : startRow;
            int LastIndex = decideFromIndex + row;
            if (Down)
            {
                if (decideFromIndex == sv.RowCount - 1 | decideFromIndex < 0)
                    return;
                CellMove(decideFromIndex, LastIndex, row, decideFromIndex + 1, ColIndex, Col);
            }
            else
            {
                if (decideFromIndex <= 0)
                    return;
                CellMove(decideFromIndex, decideFromIndex - 1, row, decideFromIndex - 1, ColIndex, Col);
            }
        }
        private void CellMove(int FromIndex, int toIndex, int rowCount, int IndexUpDown, int colIndex, int colCount)
        {
            sv.MoveRow(FromIndex, toIndex, rowCount, true);
            sv.SetActiveCell(IndexUpDown, sv.Columns[_Name].Index, true);
            sv.AddSelection(IndexUpDown, colIndex, rowCount, colCount);
        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            if (sv.ColumnHeader.Columns[_Name].Index == e.Column && !e.ColumnHeader)
            {
                if (e.Button == MouseButtons.Right)
                {
                    spr.ContextMenuStrip = ContextMenuStrip2;
                }
            }
        }

        private void spr_DialogKey(object sender, FarPoint.Win.Spread.DialogKeyEventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            if (e.KeyCode == Keys.Enter)
            {
                sv.SetActiveCell(sv.ActiveRowIndex + 1, sv.ActiveColumnIndex);
            }
        }

        private void spr_KeyDown(object sender, KeyEventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            if (e.KeyCode == Keys.Delete)
            {
                SetSprKeyDelete();
            }
        }
        private void SetSprKeyDelete()
        {
            if (sv.RowCount == 1)
                return;
            var row = default(int);
            var decideFromIndex = default(int);
            SetSprRemoveCellRowIndex(ref decideFromIndex, ref row);
            if (decideFromIndex == -1)
                return;
            for (int i = decideFromIndex, loopTo = decideFromIndex + row - 1; i <= loopTo; i++)
            {
                if (sv.Cells[i, sv.Columns[_Code].Index].Value != null)
                {
                    RemoveNodeNameList.Add(sv.Cells[i, sv.Columns[_Name].Index].Value.ToString());
                }
            }
        }
        private void SetSprRemoveCellRowIndex(ref int decideFromIndex, ref int row)
        {
            int startRow = sv.ActiveRowIndex;
            FarPoint.Win.Spread.Model.CellRange[] DragCell = sv.GetSelections();
            if (DragCell.Length == 0)
            {
                decideFromIndex = -1;
                row = -1;
                return;
            }
            var ColIndex = DragCell[0].Column;
            int Col = DragCell.Length == 0 ? 0 : DragCell[0].ColumnCount;
            row = DragCell.Length == 0 ? 1 : DragCell[0].RowCount;
            int lastRow = M_UpPt.Y < M_DownPt.Y ? startRow - (row - 1) : startRow + (row - 1);
            decideFromIndex = lastRow < startRow ? startRow - (row - 1) : startRow;
        }

        private void spr_KeyUp(object sender, KeyEventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            if (sv.ActiveRowIndex == -1)
                return;
            if (e.KeyCode == Keys.Delete)
            {
                if (sv.RowCount == 1)
                    return;
                var row = default(int);
                var decideFromIndex = default(int);
                SetSprRemoveCellRowIndex(ref decideFromIndex, ref row);
                if (decideFromIndex == -1)
                    return;
                sv.RemoveRows(decideFromIndex, row);
            }
            else if (e.KeyCode == Keys.Insert)
            {
                sv.AddRows(sv.ActiveRowIndex, 1);
                AddCellList.Add(sv.ActiveRowIndex);
            }
        }

        private void spr_MouseDown(object sender, MouseEventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            M_DownPt = e.Location;
        }

        private void spr_MouseUp(object sender, MouseEventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            M_UpPt = e.Location;
        }

        private void _node수정_Click(object sender, EventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            SetTvLabelModi(true);
        }

        private void _Code수정_Click(object sender, EventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            ToolPdfFileOpen?.Invoke(Code수정.Text, e);
        }

        private void _Code삭제_Click(object sender, EventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            MenuNodePdfDel?.Invoke(tv_manager.SelectedNode.FullPath, e);
            SelectedNode.NodeFont = null;
        }

        private void _node삭제_Click(object sender, EventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            MenuNodeDel?.Invoke(tv_manager.SelectedNode, e);
        }

        private void _Row추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            var sprKeyEv = new KeyEventArgs(Keys.Insert);
            spr_KeyUp(default, sprKeyEv);
        }

        private void _Row제거ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            var sprKeyEv = new KeyEventArgs(Keys.Delete);
            spr_KeyDown(default, sprKeyEv);
            spr_KeyUp(default, sprKeyEv);
        }

        private void _tv_manager_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            FirstNodeClick = false;
            if (e.Node.ImageIndex == 2 | e.Node.SelectedImageIndex == 2)
                ManagerTv_ImageIndex(e.Node, 1);
        }

        private void _tv_manager_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            FirstNodeClick = false;
            if (e.Node.ImageIndex == 1 | e.Node.SelectedImageIndex == 1)
                ManagerTv_ImageIndex(e.Node, 2);
        }

        private void _tv_manager_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            SetTvLabelModi(false, e);
        }
        private void SetTvLabelModi(bool @bool, NodeLabelEditEventArgs e = default)
        {
            switch (@bool)
            {
                case true:
                    {
                        tv_manager.LabelEdit = true;
                        tv_manager.SelectedNode.BeginEdit();
                        break;
                    }
                case false:
                    {
                        if (tv_manager.LabelEdit)
                            SetTvLabelEdit(e);
                        break;
                    }
            }
        }
        private void SetTvLabelEdit(NodeLabelEditEventArgs e)
        {
            string PrevText = e.Node.Text;
            string ChangeText = e.Label;
            if (string.IsNullOrEmpty(ChangeText))
                e.CancelEdit = true;
            tv_manager.LabelEdit = false;

            var result = MessageBox.Show($"{PrevText}을 {ChangeText}로 수정 하시겠습니까? ", string.Empty, MessageBoxButtons.YesNo);
            if (DialogResult.Yes == result)
            {
                e.Node.EndEdit(false);
                if (e.Node.NodeFont != null)
                {
                    MenuNodeModify?.Invoke(ChangeText, "pdf");
                }
                else
                {
                    MenuNodeModify?.Invoke(ChangeText, string.Empty);
                }
                e.CancelEdit = false;
                ContextMenuStrip1.Hide();
                SetClear(false, true);
                ListClear();
            }
            else
            {
                e.CancelEdit = true;
            }
            tv_manager.LabelEdit = false;
        }

        private void _tv_manager_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            if (e.Bounds.Height < 1 || e.Bounds.Width < 1)
                return; // DrawNode 를 너무 자주 타게되면은 이미지가 겹쳐보이는 형상이생겨 추가 코딩
            TreeNode Node = default;
            e.DrawDefault = true;
            var x1 = e.Node.Bounds.Right + 2;
            var pdfY1 = e.Node.Bounds.Top + 2;
            var ArrowY1 = e.Node.Bounds.Top + 4;
            if (e.Node.NodeFont != null)
            {
                e.Graphics.DrawImage(Properties.Resources.pdf01, new Point(x1, pdfY1));
                x1 = 15 + e.Node.Bounds.Right + 2;
            }
            if (object.ReferenceEquals(e.Node, tv_manager.SelectedNode))
                e.Graphics.DrawImage(Properties.Resources.arrow01, new Point(x1, ArrowY1)); // New Rectangle(x1, y1, 15, 15)
        }

        private void _tv_manager_KeyDown(object sender, KeyEventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            if (e.KeyCode == Keys.Right)
            {
                if (tv_manager.SelectedNode.FirstNode is null)
                {
                    FirstNodeClick = false;
                    var treeNodeEvent = new TreeNodeMouseClickEventArgs(tv_manager.SelectedNode, MouseButtons.Left, 2, 0, 0);
                    _tv_manager_NodeMouseDoubleClick(default, treeNodeEvent);
                }
            }
            else if (e.KeyCode == Keys.F3)
            {
                SetTvLabelModi(true);
            }
        }

        private void _tv_manager_KeyUp(object sender, KeyEventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            FirstNodeClick = false;
            switch (e.KeyCode)
            {
                case var @case when @case == Keys.Down:
                case var case1 when case1 == Keys.Up:
                    {
                        SetNodeFullpath(tv_manager.SelectedNode);
                        var treeNodeEvent = new TreeNodeMouseClickEventArgs(tv_manager.SelectedNode, MouseButtons.Left, 1, 0, 0);
                        _tv_manager_NodeMouseClick(default, treeNodeEvent);
                        break;
                    }
                case var case2 when case2 == Keys.Left:
                    {
                        tv_manager.SelectedNode.Collapse();
                        break;
                    }
            }
        }
        public void SetNodeFullpath(TreeNode SelectedNode)
        {
            var Path = "경로 : " + SelectedNode.FullPath.Replace("|", ">");
            int MaxLength = 35;
            int defaultHeight = 21;
            int i = 1;
            NodePath(Path, MaxLength, defaultHeight, i);
        }
        private void NodePath(string Path, int MaxLength, int defaultHeight, int i)
        {
            if (Path.Length < MaxLength)
            {
                txtAddr.Text = Path;
                txtAddr.Height = defaultHeight;
            }
            i += 1;
            if (Path.Length > MaxLength & i * MaxLength > Path.Length)
            {
                string svPath = Strings.Left(Path, MaxLength - 1) + Constants.vbCrLf + Strings.Mid(Path, MaxLength, Path.Length);
                int svHeight = i * defaultHeight;
                txtAddr.Text = svPath;
                txtAddr.Height = svHeight;
                NodePath(svPath, i * MaxLength, svHeight, i);
            }
        }

        private void _tv_manager_MouseMove(object sender, MouseEventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            if (tv_manager.GetNodeAt(e.Location) != null)
            {
                tv_manager.Cursor = Cursors.Hand;
            }
            else
            {
                tv_manager.Cursor = Cursors.Default;
            }
        }

        private void _tv_manager_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            if (e.Node is null)
                return;
            FirstNodeClick = false;
            ListClear();
            sv.ClearRange(0, 0, sv.RowCount, sv.ColumnCount, true);
            switch (e.Button)
            {
                case var @case when @case == MouseButtons.Left:
                    {
                        SetNodeClickLeft(sender, e);
                        break;
                    }
                case var case1 when case1 == MouseButtons.Right:
                    {
                        if (spr.Visible == false)
                            return;
                        if (e.Node != null)
                            SetNodeClickRight(e);
                        break;
                    }
            }
        }
        private void SetNodeClickRight(TreeNodeMouseClickEventArgs e)
        {
            tv_manager.SelectedNode = e.Node;
            e.Node.ContextMenuStrip = ContextMenuStrip1;
            if (e.Node.NodeFont is null)
            {
                e.Node.ContextMenuStrip.Items[1].Text = "Code 추가";
                e.Node.ContextMenuStrip.Items[2].Enabled = false;
            }
            else
            {
                e.Node.ContextMenuStrip.Items[1].Text = "Code 수정";
                e.Node.ContextMenuStrip.Items[2].Enabled = true;
            }
            SetNodeFullpath(e.Node);
        }
        private void SetNodeClickLeft(object sender, TreeNodeMouseClickEventArgs e)
        {
            btnInsertChecked = false;
            tv_manager.SelectedNode = e.Node;
            if (e.Node.IsExpanded)
            {
                if (sender != null)
                {
                    e.Node.Collapse(true);
                }
                else
                {
                    NodeMouseClick?.Invoke(e.Node.FullPath, e);
                }
            }
            else if (!e.Node.IsExpanded)
            {
                NodeMouseClick?.Invoke(e.Node.FullPath, e);
                if (sender != null)
                    e.Node.Expand();
            }
            SetNodeFullpath(e.Node);
        }

        private void _tv_manager_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (GetCmbGubunChecked() == false)
                return;
            if (e.Button == MouseButtons.Left)
                SetNodeDoubleClickLeft(e);
        }
        private void SetNodeDoubleClickLeft(TreeNodeMouseClickEventArgs e)
        {
            ListClear();
            FirstNodeClick = false;
            NodeMouseDoubleClick?.Invoke(e.Node.FullPath, e);
            if (!(e.Node.ImageIndex == 0 | e.Node.SelectedImageIndex == 0))
            {
                if (e.Node.IsExpanded)
                {
                    ManagerTv_ImageIndex(e.Node, 2);
                }
                else
                {
                    ManagerTv_ImageIndex(e.Node, 1);
                }
            }
            NodeMouseClick?.Invoke(e.Node.FullPath, e);
        }
    }
}
