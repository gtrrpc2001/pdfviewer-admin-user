using Microsoft.VisualBasic;
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
    public partial class frmCodeEdit : Form
    {
        public string PdfPath { get; set; }
        private string Nodepath { get; set; }
        private int Page { get; set; }
        private bool Success { get; set; }
        public frmCodeEdit(string pdfPath, string Nodepath, int page, ref bool success)
        {
            InitializeComponent();
            this.PdfPath = pdfPath;
            this.Nodepath = Nodepath;
            this.Page = page;
            this.Success = success;
        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            var pageList = dataController.GetCodeCountChecked(PdfPath, txtCode.Text);
            if (pageList.Count() == 1)
            {                
                Success = dataController.DataQuery.GetDataUpdate(Nodepath, txtCode.Text, pageList[0]);
                Interaction.MsgBox("수정 되었습니다..");
                Close();
            }
            else
            {
                Interaction.MsgBox("다른 코드를 등록해 주세요.");
            }
        }

        private void frmCodeEdit_Load(object sender, EventArgs e)
        {
            PdfViewer2.LoadDocument(PdfPath);
            PdfViewer2.CurrentPageNumber = Page;
        }
    }
}
