using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookKeeper.Model.Repositories;
using BookKeeper.View;

namespace BookKeeper.Presenters
{
    public interface IPresenter<T> where T : Model.Items.IBaseItem
    {
        void Add(IPopupForm<T> popup);
        void Remove(IListButton<T> button);
        void RemakeItems();
    }
}
