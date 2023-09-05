using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfViewer.usercontrol
{
    public partial class Search : UserControl
    {
        public event PageMove_withTxtEventHandler PageMove_withTxt;
        public delegate void PageMove_withTxtEventHandler(String txtSearch);

        public event TxtValueChangedEventHandler TxtValueChanged;
        public delegate void TxtValueChangedEventHandler();
        public Search()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PageMove_withTxt?.Invoke(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                PageMove_withTxt?.Invoke(txtSearch.Text);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            TxtValueChanged?.Invoke();
        }
    }
}
