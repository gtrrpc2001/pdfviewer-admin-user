using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfViewer.Class.clsNode
{
    public class clsNodeSearch : clsNodeController
    {
        public TreeNode[] NodeFild(TreeNodeCollection NodeCollection, string key)
        {
            TreeNode[] Nodes = null;
            int index = 0;
            foreach (TreeNode node in NodeCollection)
            {
                Array.Resize(ref Nodes, index + 1);
                Nodes[index] = GetNodeByText(node, key);
                nodeFound = false;
                if (Nodes[index] != null)
                {
                    NodeExpand(Nodes[index]);
                    index += 1;
                }
            }
            return Nodes;
        }
        private bool nodeFound = false;
        private TreeNode GetNodeByText(TreeNode nodes, string searchText)
        {
            TreeNode foundNode;
            if (nodes.Text.Contains(searchText))
            {
                SetNodeColor(nodes);
                nodeFound = true;
            }
            foreach (TreeNode node in nodes.Nodes)
            {
                if (node.Text.Contains(Strings.LCase(searchText)) | node.Text.Contains(Strings.UCase(searchText)))
                {
                    nodeFound = true;
                    SetNodeColor(node);
                    if (nodes.Nodes[nodes.Nodes.Count - 1].Text == node.Text)
                        return nodes;
                }
                else if (nodes.Text.Contains(searchText))
                {
                    SetNodeColor(nodes);
                    if (nodes.Nodes[nodes.Nodes.Count - 1].Text == node.Text)
                        nodeFound = true;
                }
                foundNode = GetNodeByText(node, searchText);
                if (foundNode != null)
                {
                    if (foundNode.Parent != null)
                    {
                        if (nodes.Nodes[nodes.Nodes.Count - 1].Text == node.Text)
                            return foundNode.Parent;
                    }
                }
            }
            if (nodeFound)
                return nodes;
            return default;
        }
        private void SetNodeColor(TreeNode Node)
        {
            Node.BackColor = Color.Aqua;
        }
    }
}
