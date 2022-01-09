using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookKeeper.View
{
    public class TablePanelNode : TableLayoutPanel
    {
        [Category("Node Attributes")]
        public NodeType Type { get; set; }

        private TablePanelNode _childPanel;
        
        [Category("Node Attributes")]
        public TablePanelNode ChildPanel
        {
            get => Type.IsLeaf() ? this : _childPanel;

            set => _childPanel = Type.IsLeaf() ? this : value;
        }

        private TablePanelNode _parentPanel;
        
        [Category("Node Attributes")]
        public TablePanelNode ParentPanel {
            get => Type.IsRoot() ? this : _parentPanel;

            set => _parentPanel = Type.IsRoot() ? this : value;
        }
    }
    public enum NodeType
    {
        Root,
        Parent,
        Leaf
    }
    static class NodeMethods
    {
        public static bool IsRoot(this NodeType node)
        {
            return node == NodeType.Root;
        }
        public static bool IsParent(this NodeType node)
        {
            return node == NodeType.Parent;
        }
        public static bool IsLeaf(this NodeType node)
        {
            return node == NodeType.Leaf;
        }
    }

}
