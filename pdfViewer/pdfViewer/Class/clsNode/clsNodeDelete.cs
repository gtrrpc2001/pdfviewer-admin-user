using Microsoft.VisualBasic.CompilerServices;
using pdfViewer.Class.clsQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfViewer.Class.clsNode
{
    public class clsNodeDelete : clsNodeController
    {
        public DialogResult GetMessageResult(string FullPath, string nodeText, ref int index)
        {
            var dT = clsQueryController.SelectTv.GetSelect_No(FullPath);
            if (dT.Rows.Count == 0)
            {
                index = Editor.UpdateDataBaseIndex(FullPath) - 1;
                return DialogResult.Yes;
            }
            index = Conversions.ToInteger(dT.Rows[0]["tv_no"]) - 1;
            string message = $"{nodeText} 안에 {dT.Rows.Count} 개만큼 아이템이 있습니다. 그래도 삭제 하시겠습니까?";
            string caption = "";
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }
        public void SetNodeDelete(string fullPath, TreeNode selectedNode)
        {
            clsQueryController.Delete.SetNodeDelete(fullPath, selectedNode);
        }
    }
}
