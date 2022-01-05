using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookKeeper.Model.Items;
using BookKeeper.Model.Repositories;
using BookKeeper.View;

namespace BookKeeper.Presenters
{
    public class UserPresenter : IPresenter<UserItem>
    {
        private MainForm View { get; set; }
        private IRepository<UserItem> Repository { get; set; }
        public UserPresenter(UserRepository repository, MainForm view)
        {
            this.Repository = repository;
            this.View = view;
            view.Presenter = this;
            AddAllUsersToView();
        }
        public void Save()
        {
            Repository.SaveRepoToFile();
        }
        public void Remove(int index)
        {
            if (index < Repository.Count && index >= 0)
            {
                Repository.RemoveItem(index);
                View.UserFlowLayoutPanel.Controls.Remove(View.UserFlowLayoutPanel.Controls[index]);
                UpdateListButtonIDs();
            }
        }
        public void Remove(UserItem item)
        {
            if (item.Name != "" && item.ID < Repository.Count)
            {
                View.UserFlowLayoutPanel.Controls.Remove(View.UserFlowLayoutPanel.Controls[item.ID]);
                Repository.RemoveItem(item.ID);
                UpdateListButtonIDs();
            }
        }
        public void Remove(PopupForm popup)
        {
            popup.OutputText(out string text);
            if (text != "" && 
                Int32.TryParse(text, out int index) && 
                index < Repository.Count && 
                Repository.Count != 0)
            {
                View.UserFlowLayoutPanel.Controls.Remove(View.UserFlowLayoutPanel.Controls[index]);
                Repository.RemoveItem(index);
                UpdateListButtonIDs();
            }
        }
        public void Add(UserItem item)
        {
            if (item.Name!="")
            {
                this.Repository.AddItem(item);
                AddUserToView(item);
            }
        }
        public void Add(PopupForm popup)
        {
            popup.OutputText(out string text);
            if (text != "")
            {
                this.Repository.AddItem(
                    new UserItem(
                        text,
                        Repository.LastID()+1)
                    );
                AddUserToView(Repository.GetAllItems().Last());
                Save();
            }
        }

        private void AddUserToView(UserItem user)
        {
            System.Drawing.Size size = new System.Drawing.Size(338,40);
            if (Repository.Count > 8)
                size = new System.Drawing.Size(320, 40);

            View.UserFlowLayoutPanel.Controls.Add(new ListButton(user, size, this));
        }
        private void AddAllUsersToView()
        {
            foreach (UserItem user in Repository.GetAllItems())
            {
                AddUserToView(user);
            }
        }
        public void EditItem(int index)
        {
            new PopupForm("Edit User", "Name", Repository.GetItem(index).Name).OutputText(out string text);
            if (text != "")
            {
                Repository.EditItemName(text, index);
                UpdateViewAt(index);
            }
        }
        private void UpdateListButtonIDs()
        {
            for (int i = 0; i < View.UserFlowLayoutPanel.Controls.Count; i++)
            {
                ((ListButton)View.UserFlowLayoutPanel.Controls[i]).ID = i;
            }
        }
        private void UpdateViewAt(int index)
        {
            View.UserFlowLayoutPanel.Controls[index].Text = Repository.GetItem(index).Name;
            ((ListButton)View.UserFlowLayoutPanel.Controls[index]).ID = Repository.GetItem(index).ID;
        }
        public void RemakeItems()
        {
            Repository.RemakeRepo();
            View.UserFlowLayoutPanel.Controls.Clear();
            AddAllUsersToView();
        }
    }
}
