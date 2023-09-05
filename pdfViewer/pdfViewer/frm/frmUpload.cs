using FarPoint.Win.Spread;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using pdfViewer.Class;
using pdfViewer.Class.clsPdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfViewer.frm
{
    public partial class frmUpload : Form
    {
        #region Tag
        private const string _Name = "Name";
        private const string _Path = "Path";
        #endregion
        #region property
        public SheetView sv
        {
            get
            {
                return spr_Sheet1;
            }
        }
        #endregion
        public frmUpload()
        {
            InitializeComponent();
            clsSpread.SpreadSetCursor(this);
        }
        #region Get
        private string GetVersion(string path)
        {
            var sc = new ServerComputer();
            var result = sc.FileSystem.OpenTextFileReader(path);
            var read = result.ReadToEndAsync();
            read.Wait();
            var version = read.Result.ToString();
            read.Dispose();
            return version;
        }
        #endregion
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.FileName = string.Empty;
            OpenFileDialog1.Multiselect = true;
            var result = OpenFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileNames = OpenFileDialog1.FileNames;
                var length = fileNames.Length - 1;
                if (length > 1)
                {
                    Interaction.MsgBox("파일을 2개만 선택해주세요");
                    return;
                }
                int row = length > 1 ? 1 : length;
                if (row == 0)
                {
                    var startRow = GetRow();
                    int index = startRow == 0 ? 0 : startRow - 1;
                    if (fileNames[index].Contains("Version.txt"))
                        txtVersion.Text = GetVersion(fileNames[index]);
                    sv.Cells[startRow, sv.Columns[_Name].Index].Value = Path.GetFileName(fileNames[index]);
                    sv.Cells[startRow, sv.Columns[_Path].Index].Value = fileNames[index];
                }
                else
                {
                    for (int i = 0, loopTo = row; i <= loopTo; i++)
                    {
                        if (fileNames[i].Contains("Version.txt"))
                            txtVersion.Text = GetVersion(fileNames[i]);
                        sv.Cells[i, sv.Columns[_Name].Index].Value = Path.GetFileName(fileNames[i]);
                        sv.Cells[i, sv.Columns[_Path].Index].Value = fileNames[i];
                    }
                }
            }
        }
        private int GetRow()
        {
            int row = 0;
            for (int i = 0; i <= 1; i++)
            {
                if (sv.Cells[i, sv.Columns[_Path].Index].Value != null)
                    row += 1;
            }
            return row;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            sv.ClearRange(0, 0, 2, 2, true);
            txtVersion.Text = "";
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("업로드 하시겠습니까??", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var path = new List<string>();
                var fileName = new List<string>();
                for (int i = 0, loopTo = sv.GetLastNonEmptyRow(NonEmptyItemFlag.Data); i <= loopTo; i++)
                {
                    path.Add(sv.Cells[i, sv.Columns[_Path].Index].Value?.ToString());
                    fileName.Add(sv.Cells[i, sv.Columns[_Name].Index].Value?.ToString());
                }
                if (path.Count < 2)
                {
                    Interaction.MsgBox("PDF 파일 과 Version 파일을 같이 올려주세요.");
                    return;
                }
                var frm = new frmDataCheck(path, fileName, txtVersion.Text);
                frm.Show();
                frm.FormClosed += (s,se) => btnReset_Click(default, default);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var _result = MessageBox.Show("PDF를 다운 받으시겠습니까??", "", MessageBoxButtons.YesNo);
            if (_result == DialogResult.Yes)
            {
                clsPdfController.Save.GetDirectoryPath();
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
                    var onlyFileName = Path.GetFileName(filePath);
                    //clsPdfController.Save.SetUpload(filePath, onlyFileName);
                    clsPdfController.Save.SetUpdate(filePath, onlyFileName);
                }
            }
        }
    }
}
