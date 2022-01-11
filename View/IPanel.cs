using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKeeper.View
{
    public interface IPanel<T> where T : Model.Items.IBaseItem
    {
        public void BringToFront();
    }
}
