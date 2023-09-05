using Microsoft.VisualBasic.CompilerServices;
using pdfViewer.Class;
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
    public partial class frmServer : Form
    {
        public string SERVER;
        public string UID;
        public string PWD;
        public int PORT;        
        public bool MysqlConChecked;
        public frmServer()
        {
            InitializeComponent();
        }
        private void PopulateTreeView(int parentId, TreeNode parentNode)
        {
            var myCon = new MysqlController();
            string Seqchildc = "SELECT tv_no,tv_name,tv_dup FROM pdf.tv WHERE tv_dup=" + parentId + "";
            var dT = myCon.MysqlSelect(Seqchildc);
            TreeNode childNode;
            foreach (DataRow dR in dT.Rows)
            {
                if (parentNode is null)
                {
                    childNode = TreeView1.Nodes.Add(dR["tv_name"].ToString());
                }
                else
                {
                    childNode = parentNode.Nodes.Add(dR["tv_name"].ToString());
                }

                PopulateTreeView(Convert.ToInt32(dR["tv_dup"].ToString()), childNode);
            }
        }

        private void BTN_Click(object sender, EventArgs e)
        {
            SERVER = txtSer.Text;
            UID = txtU.Text;
            PWD = txtp.Text;
            PORT = Conversions.ToInteger(txtport.Text);
            ExtensionSource. DBname = txtDBName.Text;
            ExtensionSource. myCon = new MysqlController();
            if (ExtensionSource.myCon.DatabaseConnection(SERVER, UID, PWD, PORT))
            {
                MysqlConChecked = true;
                Close();
            }            
        }

        private void txtport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BTN_Click(default,default);
        }
    }
}
