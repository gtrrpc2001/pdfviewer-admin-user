using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace pdfViewer.usercontrol
{
    public partial class UserTreeView : TreeView
    {
        private DateTime lastMouseDown = DateTime.Now;
        private bool _preventExpand;
        public bool preventExpand
        {
            get { return _preventExpand; }
            set { _preventExpand = value; }
        }

        public UserTreeView()
        {
            
        }

        private void UserTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            Point myPoint = Cursor.Position;
            Point p = this.PointToClient(myPoint);
            TreeNode node = this.GetNodeAt(p);
            if (node == null && preventExpand)
            {
                e.Cancel = true; preventExpand = false;
            }
        }

        private void UserTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            var delta = System.Convert.ToInt32(DateTime.Now.Subtract(lastMouseDown).TotalMilliseconds);
            preventExpand = (delta < SystemInformation.DoubleClickTime);
            lastMouseDown = DateTime.Now;
        }

        private void UserTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left | e.Button == MouseButtons.Right)
            {
                this.BeginUpdate();
                this.EndUpdate();
            }
        }
    }
}
