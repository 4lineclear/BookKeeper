using BookKeeper.Model.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookKeeper.View
{
    public partial class BookListPanel : DerivedPanel<BookListItem,UserItem,BookListItem>
    {
        public BookListPanel()
        {
            InitializeComponent();
        }
        public override void BringToFront()
        {
            base.BringToFront();
        }
    }
}
