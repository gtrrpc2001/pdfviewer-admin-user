using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using pdfViewer.Class.clsQuery;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfViewer.Class.clsNode
{
    public class clsNodeSelect : clsNodeController
    {
        private List<TvModel> _tvList;
        private List<TvModel> tvList
        {
            get
            {
                if (_tvList is null)
                    _tvList = new List<TvModel>();
                return _tvList;
            }
        }
        private void ListAdd(string Name, int No, int Dup, bool PdfNull)
        {
            tvList.Add(new TvModel(Name, No, Dup, PdfNull));
        }
        private void ListClear()
        {
            tvList.Clear();
        }
        private void SelectNode(TreeNodeCollection AddTreeNode)
        {
            TreeNode node = default;
            var tvArr = (from t in tvList
                         where t.No == 0
                         orderby t.Dup ascending
                         select new { t.Name, t.No, t.Dup, t.PdfNull }).ToArray();
            string tv_name = "";
            if (tvArr.Length != 0)
                SetTreeView(tvArr, node, tv_name, 0, AddTreeNode);
        }
        private void SetTreeView(Array tvArr, TreeNode parentNodes, string tv_name, int i, TreeNodeCollection AddTreeNode = default)
        {
            var childNode = default(TreeNode);
            if (parentNodes != null & i != -2)
                tvArr = (from t in tvList
                         where t.No == i + 1 & t.Name.Contains(tv_name)
                         select new { t.No, t.Name, t.Dup, t.PdfNull }).ToArray();
            int index = -1;
            Array svArr = null;
            foreach (dynamic tv in tvArr)
            {
                int PdfInt = 1;
                // If tv.PdfNull = False Then PdfInt = 3
                if (parentNodes is null)
                {
                    childNode = AddTreeNode.Add(tv.Name, tv.Name, PdfInt, PdfInt);
                    SetTreeView(tvArr, childNode, Operators.ConcatenateObject(tv.Name, "|").ToString(), tv.No);
                }
                else
                {
                    string InputName = tv.Name.ToString().Replace(tv_name, "");
                    if (GetCheckName(tv_name, Conversions.ToString(tv.Name)) == false)
                        goto here;
                    index += 1;
                    parentNodes.Nodes.Insert(index, InputName, InputName, PdfInt, PdfInt);
                    childNode = parentNodes.Nodes[index];
                    svArr = (from t in tvList
                             where Operators.ConditionalCompareObjectEqual(t.No, Operators.AddObject(tv.No, 1), false) & t.Name.Contains(Operators.ConcatenateObject(tv.Name, "|").ToString())
                             orderby t.Dup ascending
                             select new { t.No, t.Name, t.Dup, t.PdfNull }).ToArray();
                    if (svArr.Length == 0)
                    {
                        svArr = null;
                        SetImageIndex(childNode, PdfInt);
                    } // childNode.ImageIndex = If(PdfInt = 1, 0, PdfInt)
                    if (svArr != null)
                        SetTreeView(svArr, childNode, Operators.ConcatenateObject(tv.Name, "|").ToString(), -2);
                    here:
                    ;
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(tv.PdfNull, false, false)) && childNode != null)
                    childNode.NodeFont = new Font("돋움", 9);
                if (childNode.FirstNode is null)
                    SetImageIndex(childNode, PdfInt); // childNode.ImageIndex = If(PdfInt = 1, 0, PdfInt)
            }
        }
        private void SetImageIndex(TreeNode childNode, int PdfInt)
        {
            childNode.ImageIndex = PdfInt == 1 ? 0 : PdfInt;
            childNode.SelectedImageIndex = PdfInt == 1 ? 0 : PdfInt;
        }
        private bool GetCheckName(string PrevName, string NewName)
        {
            if ((Strings.Mid(PrevName, 1, PrevName.IndexOf("|") + 1) ?? "") != (Strings.Mid(NewName, 1, NewName.IndexOf("|") + 1) ?? ""))
                return false;
            return true;
        }
        public void SetNodesSelect(TreeNodeCollection TreeNodeCollection, [Optional, DefaultParameterValue(false)] ref bool MokchaInsertChecked, bool ManagerChecked = false)
        {
            var dT = clsQueryController.SelectTv.GetJoinSelect_Code_No();
            if (ManagerChecked)
                MokchaInsertChecked = GetManagerNodeSelectChecked(dT);
            ListClear();
            foreach (DataRow dR in dT.Rows)
            {
                bool pdfchecked = true;
                if (dR["tv_Code"].ToString() != "")
                    pdfchecked = false;
                ListAdd(dR["tv_name"].ToString(), Conversions.ToInteger(dR["tv_no"]), Conversions.ToInteger(dR["tv_dup"]), pdfchecked);
            }
            SelectNode(TreeNodeCollection);
        }
        private bool GetManagerNodeSelectChecked(DataTable dT)
        {
            if (dT.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private partial struct TvModel
        {
            public string Name;
            public int No;
            public int Dup;
            public bool PdfNull;
            public TvModel(string Name, int No, int Dup, bool PdfNull)
            {
                this.Name = Name;
                this.No = No;
                this.Dup = Dup;
                this.PdfNull = PdfNull;
            }
        }
    }
}
