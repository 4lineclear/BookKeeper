using BookKeeper.Model.Items;
using BookKeeper.Model.Repositories;
using BookKeeper.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKeeper.Presenters
{
    public class BasePresenter<T,U,V> 
        where T : Model.Items.BaseItem
        where U : Model.Items.BaseItem
        where V : Model.Items.BaseItem
    {
        protected BasePanel<T,U,V> MainPanel { get; }
        protected BaseRepository<T> Repository { get; }
        public BasePresenter(BaseRepository<T> repository, BasePanel<T,U,V> mainPanel)
        {
            this.Repository = repository;
            this.MainPanel = mainPanel;
            mainPanel.Presenter = this;
            AddAllUsersToView();
        }
        public void Save()
        {
            Repository.SaveRepoToFile();
        }
        public void Add(IPopupForm<T> popup)
        {
            if (popup.OutputText(out string text))
            {
                this.Repository.AddItem(text);
                AddItemToView(Repository.GetAllItems().Last());
                Save();
            }

        }
        public void EditItem(BaseListButton<T, U, V> button)
        {
            int index = MainPanel.GetButtonIndex(button);
            if (new BasePopupForm<T>("Edit User", "Name", Repository.GetItem(index).Name).OutputText(out string text))
            {
                Repository.EditItemName(text, index);
                button.Text = Repository.GetItem(index).Name;
            }
        }
        public void Remove(BaseListButton<T, U, V> button)
        {
            Repository.RemoveItem(MainPanel.GetButtonIndex(button));
            MainPanel.RemoveButton(button);
        }
        private void AddItemToView(T item)
        {
            System.Drawing.Size size;

            if (Repository.Count > 8)
                size = new System.Drawing.Size(320, 40);
            else
                size = new System.Drawing.Size(338, 40);

            MainPanel.AddButton(new BaseListButton<T, U, V>(item, size, this));
        }
        public void AddAllUsersToView()
        {
            foreach (T t in Repository.GetAllItems())
            {
                AddItemToView(t);
            }
        }
        public void RemakeItems()
        {
            Repository.RemakeRepo();
            MainPanel.ClearButtons();
            AddAllUsersToView();
        }
    }
}
