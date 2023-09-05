using Microsoft.VisualBasic;
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
    public partial class frmCodeList : Form
    {
        private TreeNode node;
        private string DocumentFilePath;
        public frmCodeList(TreeNode node,string DocumentFilePath)
        {
            InitializeComponent();
            this.node = node;
            this.DocumentFilePath = DocumentFilePath;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var Code = txtCode.Text;
            if (Code == "")
                return;
            int page = Code == "" ? 0 : clsPdfController.Select.GetCodePage(DocumentFilePath, Code);
            if (page == -1)
            {
                Interaction.MsgBox($"{Code} :: 중복된 코드가 있거나 코드가 정확하지 않습니다..");
                return;
            }
            dataController.DataQuery.GetDataUpdate(node.FullPath, Code, page);
            node.NodeFont = new Font("돋움", 9);
            Close();
        }
    }
}
