using FarPoint.Win.Spread;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using pdfViewer.Class;
using pdfViewer.Class.clsPdf;
using pdfViewer.Class.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfViewer.frm
{
    public partial class frmDataCheck : Form
    {
        #region 전역
        private List<string> Filepath;
        private List<string> fileName;
        private string version;
        #endregion
        #region Tag
        private const string _Code = "Code";
        private const string _Path = "Path";
        private const string _Page = "Page";
        private const string Error = "Error";
        private const string _Button = "Button";
        #endregion
        #region property
        private SheetView sv
        {
            get
            {
                return spr_Sheet1;
            }
        }
        public bool isFormOpen { get; set; }
        #endregion
        public frmDataCheck(List<string> FilePath, List<string> fileName,string Version)
        {
            InitializeComponent();
            this.Filepath = FilePath;
            this.fileName = fileName;
            this.version = Version;
            clsSpread.SpreadSetCursor(this);
        }
        #region Set
        private void SetUpdate(bool closeChecked)
        {
            var dataCount = GetCellCount();
            var allRow = sv.GetLastNonEmptyRow(NonEmptyItemFlag.Data);
            for (int i = 0, loopTo = allRow; i <= loopTo; i++)
            {
                if (sv.Rows[i].BackColor != Color.Silver)
                {
                    var Code = sv.Cells[i, sv.Columns[_Code].Index].Value.ToString();
                    var Page = Conversions.ToInteger(sv.Cells[i, sv.Columns[_Page].Index].Value.ToString());
                    var nodePath = sv.Cells[i, sv.Columns[_Path].Index].Value.ToString();
                    SetDataCheck(Code, nodePath, Page, i);
                    if (sv.Cells[i, sv.Columns[_Code].Index].Value != null)
                        SetBarValue(dataCount, i);
                }
            }
            Interaction.MsgBox("업데이트가 완료되었습니다.!!");
            isFormOpen = false;
            if (closeChecked)
            {
                if (allRow == GetSuccessCount(allRow))
                    Close();
            }
        }
        private void SetDataCheck(string Code, string nodePath, int Page, int i)
        {
            var CodeChecked = dataController.GetCodeCountChecked(Filepath, Code);
            if (CodeChecked.Count() > 1)
            {
                sv.Cells[i, sv.Columns[Error].Index].Value = $"{CodeChecked.ToArray()}페이지에서 중복된 코드가 발견 됬습니다.";
            }
            else if (Page == CodeChecked[0])
            {
                SetRowColorChanged(i);
            }
            else if (dataController.DataQuery.GetDataUpdate(nodePath, CodeChecked[0]))
            {
                SetRowColorChanged(i);
            }
            else
            {
                sv.Cells[i, sv.Columns[Error].Index].Value = $"{Page}페이지가 업데이트에 실패했습니다.";
            }
            Application.DoEvents();
        }
        private void SetBarValue(int dataAllCount, int value)
        {
            bar.Value = Conversions.ToInteger(GetBarValue(dataAllCount, value));
        }
        private void SetRowColorChanged(int row)
        {
            sv.Rows[row].BackColor = Color.Silver;
        }
        private void SetUploadMessageResult()
        {
            var result = MessageBox.Show("업로드 하시겠습니까.??", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                for (int i = 0, loopTo = Filepath.Count - 1; i <= loopTo; i++)
                    clsPdfController.Save.SetUpload(Filepath[i], fileName[i], version);
            }
        }

        #endregion
        #region Get
        private int GetSuccessCount(int allRow)
        {
            int cnt = 0;
            for (int i = 0, loopTo = allRow; i <= loopTo; i++)
            {
                if (sv.Rows[i].BackColor == Color.Silver)
                    cnt += 1;
            }
            return cnt - 1;
        }
        private float GetBarValue(int dataAllCount, int value)
        {
            var sprAllCount = sv.GetLastNonEmptyRow(NonEmptyItemFlag.Data);
            var sprEmptyCount = sprAllCount - dataAllCount;
            var dataCount = value - sprEmptyCount;
            var result = (100 * dataCount) / dataAllCount;
            return (float)(result > 100 ? 100 : result);
        }
        private int GetCellCount()
        {
            int cnt = 0;
            for (int i = 0, loopTo = sv.GetLastNonEmptyRow(NonEmptyItemFlag.Data); i <= loopTo; i++)
            {
                if (sv.Rows[i].BackColor != Color.Silver)
                {
                    if (sv.Cells[i, sv.Columns[_Code].Index].Value != null)
                        cnt += 1;
                }
            }
            return cnt;
        }
        private bool GetdataErrorChecked()
        {
            for (int i = 0, loopTo = sv.GetLastNonEmptyRow(NonEmptyItemFlag.Data); i <= loopTo; i++)
            {
                if (sv.Rows[i].BackColor != Color.Silver)
                    return false;
            }
            return true;
        }
        private bool GetUpdateMessageResult(FormClosingEventArgs e)
        {
            var result = MessageBox.Show("수정되지 않은 데이터가 있습니다 그래도 닫으시겠습니까??", "", MessageBoxButtons.YesNo);
            bool Checked = false;
            if (result == DialogResult.No)
            {
                Checked = true;
                SetUpdate(false);
            }
            e.Cancel = Checked;
            return Checked;
        }

        #endregion

        private void frmDataCheck_Load(object sender, EventArgs e)
        {
            isFormOpen = true;
            var dataList = dataController.GetDataList();
            sv.RowCount = dataList.Count;
            int i = -1;
            foreach (dataModel Data in dataList)
            {
                i += 1;
                sv.Cells[i, sv.Columns[_Code].Index].Value = Data.code;
                sv.Cells[i, sv.Columns[_Path].Index].Value = Data.path;
                sv.Cells[i, sv.Columns[_Page].Index].Value = Data.page;
            }
            Shown += frmDataCheck_Shown;
            
        }
        private void frmDataCheck_Shown(object sender, EventArgs e)
        {
            var t = new Timer();
            t.Start();
            t.Interval = 1000;
            t.Tick += (s,te) =>
            {
                t.Stop();
                SetUpdate(true);
            };
        }

        private void spr_CellClick(object sender, CellClickEventArgs e)
        {
            if (sv.Rows[e.Row].BackColor == Color.Silver | isFormOpen)
                return;
            if (e.Button == MouseButtons.Left)
            {
                if (sv.Columns[_Button].Index == e.Column)
                {
                    var Page = sv.Cells[e.Row, sv.Columns[_Page].Index].Value;
                    var NodePath = sv.Cells[e.Row, sv.Columns[_Path].Index].Value;
                    var pdfPath = dataController.GetPdfPath(Filepath);
                    bool editSuccess = false;
                    var frm = new frmCodeEdit(pdfPath, NodePath.ToString(), Conversions.ToInteger(Page),ref editSuccess);
                    frm.ShowDialog();
                    if (editSuccess)
                        SetRowColorChanged(e.Row);
                }
            }
        }

        private void frmDataCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            repeat:
            ;
            if (GetdataErrorChecked() == false)
            {
                if (GetUpdateMessageResult(e))
                {
                    goto repeat;
                }
                else
                {
                    Interaction.MsgBox("업데이트가 되지 않았습니다...");
                    return;
                }
            }
            SetUploadMessageResult();

        }
    }
}
