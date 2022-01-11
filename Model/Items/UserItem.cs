using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKeeper.Model.Items
{
    public class UserItem : BaseItem
    {
        public UserItem()
            :base()
        {
            
        }
        public UserItem(string name,int id)
            :base(name,id)
        {

        }
    }
}
