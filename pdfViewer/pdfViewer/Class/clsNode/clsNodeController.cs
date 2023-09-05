using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfViewer.Class.clsNode
{
    public class clsNodeController
    {
        #region 전역
        private static clsNodeEditor _editor;
        private static clsNodeDelete _Delete;
        private static clsNodeSearch _Search;
        private static clsNodeSelect _Select;
        private static TreeNode parentNodeCheck { get; set; }
        #endregion
        #region property
        public static clsNodeEditor Editor
        {
            get
            {
                if (_editor is null)
                    _editor = new clsNodeEditor();
                return _editor;
            }
        }
        public static clsNodeDelete Delete
        {
            get
            {
                if (_Delete is null)
                    _Delete = new clsNodeDelete();
                return _Delete;
            }
        }
        public static clsNodeSearch Search
        {
            get
            {
                if (_Search is null)
                    _Search = new clsNodeSearch();
                return _Search;
            }
        }
        public static clsNodeSelect Select
        {
            get
            {
                if (_Select is null)
                    _Select = new clsNodeSelect();
                return _Select;
            }
        }
        #endregion
        #region Get
        public static Image[] GetImages()
        {
            return new[] { Properties.Resources.transparent, Properties.Resources.Right, Properties.Resources.bottom, Properties.Resources.pdf01 };
        }
        public static string GetFirstNodeText(TreeNode selectedNode)
        {
            if (selectedNode.Parent is null)
            {
                return selectedNode.Text;
            }
            else
            {
                string txt = GetFirstNodeText(selectedNode.Parent);
                return txt;
            }
        }
        public static bool GetSprNameEmptyCheck(TreeNode node, string tv_name, int i)
        {
            if (node.Nodes.Count - 1 >= i)
            {
                if (string.IsNullOrEmpty(tv_name))
                {
                    return true;
                }
            }
            else if (string.IsNullOrEmpty(tv_name))
                return true;
            return false;
        }
        public static bool GetSprNameEmptyCheck(TreeNodeCollection nodeCol, string tv_name, int i)
        {
            if (nodeCol.Count - 1 >= i)
            {
                if (string.IsNullOrEmpty(tv_name))
                {
                    return true;
                }
            }
            else if (string.IsNullOrEmpty(tv_name))
                return true;
            return false;
        }
        public static TreeNode GetFindNode(TreeNode node, string r)
        {
            foreach (TreeNode n in node.Nodes)
            {
                if (n.Text == r)
                {
                    return n;
                }
            }
            return default;
        }
        public static TreeNode GetFindNode(TreeNodeCollection nodeCol, string r)
        {
            foreach (TreeNode n in nodeCol)
            {
                if (n.Text == r)
                {
                    return n;
                }
            }
            return default;
        }
        public static string GetFindKey(string Fullpath)
        {
            if (Fullpath.Contains("|"))
            {
                int index = Fullpath.IndexOf("|");
                string key = Fullpath.Substring(index + 1);
                if (key.Contains("|"))
                {
                    key = GetFindKey(key);
                }
                return key;
            }
            return Fullpath;
        }
        public static int GetFindNodeNum(TreeNode node, string r)
        {
            string[] NodeNum = null;
            int i = -1;
            foreach (TreeNode n in node.Nodes)
            {
                if (n.Text == r)
                {
                    i += 1;
                    Array.Resize(ref NodeNum, i + 1);
                    NodeNum[i] = r;
                }
            }
            return NodeNum.Length;
        }
        public static bool GetFirstNodeChecked_Same(TreeNode Node)
        {
            if (Node.Parent is null)
            {
                if (object.ReferenceEquals(Node, parentNodeCheck))
                {
                    return false;
                }
                else
                {
                    parentNodeCheck = Node;
                    return true;
                }
            }
            else
            {
                bool ParentNode = GetFirstNodeChecked_Same(Node.Parent);
                return ParentNode;
            }
        }
        public static string GetRemoveFullpath(string tv_name, string RemoveStr)
        {
            return tv_name.Replace(RemoveStr, "");
        }

        #endregion

        public static void NodeParentExpand(TreeNode parentNode)
        {
            parentNode.Expand();
            if (parentNode.IsExpanded == false)
            {
                parentNode.Expand();
                if (parentNode.Parent != null)
                {
                    NodeParentExpand(parentNode.Parent);
                }
            }
        }
        public static void NodeExpand(TreeNode Node)
        {
            if (Node.IsExpanded == false)
            {
                Node.Expand();
                NodeExpand(Node);
            }
            else if (Node.Parent is null)
            {
                return;
            }
            else if (Node.IsExpanded)
            {
                if (Node.Parent != null)
                    NodeExpand(Node.Parent);
            }
        }
    }
}
