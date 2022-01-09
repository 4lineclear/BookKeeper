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
            get{
                return Type == NodeType.Leaf ? this : _childPanel;
            }
            set{
                if (Type != NodeType.Leaf)
                    _childPanel = value;
            }
        }

        private TablePanelNode _parentPanel;
        
        [Category("Node Attributes")]
        public TablePanelNode ParentPanel { 
            get { 
                return Type == NodeType.Root ? this : _parentPanel; 
            } 
            set {
                if (Type != NodeType.Root)
                    _parentPanel = value;
            } 
        }
        
        public enum NodeType
        {
            Root,
            Parent,
            Leaf
        }
    }
}
