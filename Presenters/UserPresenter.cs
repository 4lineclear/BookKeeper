using BookKeeper.Model.Items;
using BookKeeper.Model.Repositories;
using BookKeeper.View;
using System.Linq;

namespace BookKeeper.Presenters
{
    public class UserPresenter : IPresenter<UserItem>
    {
        private UserPanel MainPanel { get; }
        private UserRepository Repository { get; }
        public UserPresenter(UserRepository repository, UserPanel mainPanel)
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
        public void Add(PopupForm popup)
        {
            if (popup.OutputText(out string text))
            {
                this.Repository.AddItem(text);
                AddUserToView(Repository.GetAllItems().Last());
                Save();
            }
        }
        public void EditItem(ListButton button)
        {
            int index = MainPanel.GetButtonIndex(button);
            if (new PopupForm("Edit User", "Name", Repository.GetItem(index).Name).OutputText(out string text))
            {
                Repository.EditItemName(text, index);
                button.Text = Repository.GetItem(index).Name;
            }
        }
        public void Remove(ListButton button)
        {
            int index = MainPanel.GetButtonIndex(button);
            if (index < Repository.Count && index >= 0)
            {
                Repository.RemoveItem(index);
                MainPanel.RemoveButton(button);
            }
        }
        private void AddUserToView(UserItem user)
        {
            System.Drawing.Size size;

            if (Repository.Count > 8)
                size = new System.Drawing.Size(320, 40);
            else
                size  = new System.Drawing.Size(338, 40);

            MainPanel.AddButton(new ListButton(user, size, this));
        }
        private void AddAllUsersToView()
        {
            foreach (UserItem user in Repository.GetAllItems())
            {
                AddUserToView(user);
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
