using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKeeper.View
{
    public interface IPopupForm<T> where T : Model.Items.IBaseItem
    {
        public bool OutputText(out string text);
    }
}
