using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookKeeper.Model.Repositories;
using BookKeeper.View;

namespace BookKeeper.Presenters
{
    public interface IPresenter<IBaseItem>
    {
        void Add(PopupForm popup);
        void Remove(ListButton button);
        void RemakeItems();
    }
}
