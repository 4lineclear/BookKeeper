using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKeeper.View
{
    public abstract class DerivedPanel<T,U,V> : BasePanel<T,U,V>
        where T : Model.Items.BaseItem
        where U : Model.Items.BaseItem
        where V : Model.Items.BaseItem
    {
        public DerivedPanel()
        {
            
        }
        public override void BringToFront()
        {
            base.BringToFront();
        }
    }
}
