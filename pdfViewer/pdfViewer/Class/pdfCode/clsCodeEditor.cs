using Microsoft.VisualBasic.CompilerServices;
using pdfViewer.Class.clsQuery;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace pdfViewer.Class.pdfCode
{
    public class clsCodeEditor : clsCodeController
    {
        public void SetTvMenu_NameEdit(TreeNode selectedNode, string Name, string pdfName)
        {
            string fullPath = selectedNode.FullPath;
            string NodeTxt = selectedNode.Text;
            dynamic ParentNode;
            if (selectedNode.Parent is null)
            {
                ParentNode = selectedNode.TreeView;
            }
            else
            {
                ParentNode = selectedNode.Parent;
            }
            //            var ParentNode = selectedNode.Parent is null ? selectedNode.TreeView : selectedNode.Parent;
            var FindNode = ParentNode.Nodes.Find(Name, false);
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(FindNode.Length, 0, false)))
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(FindNode[0].FullPath, fullPath, false)))
                    return;
            }
            var dT = clsQueryController.SelectTv.GetJoinCode_PageSelect(fullPath);
            var dR = dT.Rows.Count > 0 ? dT.Rows[0] : null;
            if (dR is null)
                return;
            if (dT.Rows.Count > 1 && (Name ?? string.Empty) != (NodeTxt ?? string.Empty))
                FullPathUpdate(NodeTxt + "|", Name);
            string Afterfullpath = fullPath.Replace(NodeTxt, Name);
            if (!string.IsNullOrEmpty(Name))
            {
                clsQueryController.UpdateTv.SetNodeUpdate(dR["tv_name"].ToString(), Afterfullpath, pdfName);
                selectedNode.Text = Name;
            }
            if (!string.IsNullOrEmpty(pdfName) || !string.IsNullOrEmpty(dR["tv_Code"].ToString()))
                selectedNode.NodeFont = new Font("돋움", 9);
        }
        public void FullPathUpdate(string selectOldname, string tv_name)
        {
            var svdT = clsQueryController.SelectTv.GetFullPahSelect(selectOldname);
            int i = -1;
            foreach (DataRow dR in svdT.Rows)
            {
                i += 1;
                string svOldName = dR["tv_name"].ToString();
                string newName = svOldName.Replace(selectOldname, tv_name + "|");
                clsQueryController.UpdateTv.SetPathUpdate(newName, svOldName, Conversions.ToInteger(dR["tv_no"]), Conversions.ToInteger(dR["tv_dup"]));
            }
        }
    }
}
