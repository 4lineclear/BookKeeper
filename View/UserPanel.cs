using BookKeeper.Presenters;
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
    public partial class UserPanel : UserControl
    {
        public UserPanel()
        {
            InitializeComponent();
        }
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            PopupForm popup = new PopupForm("Create User", "Username");
            Presenter.Add(popup);
            if (ListButtonPanel.Controls.Count > 8)
            {
                UpdateButtonsSize(320);
                ListButtonPanel.AutoScroll = true;
            }
        }
        private void CancelUsersButton_Click(object sender, EventArgs e)
        {
            Presenter.RemakeItems();

            DisableEdit();

            if (ListButtonPanel.Controls.Count < 8)
            {
                UpdateButtonsSize(338);
            }
        }
        private void EditUsersButton_Click(object sender, EventArgs e)
        {
            EnableEdit();

            for (int i = 0; i < ListButtonPanel.Controls.Count; i++)
            {
                ((ListButton)ListButtonPanel.Controls[i]).EnableEditMode();
            }
        }
        private void SaveUsersButton_Click(object sender, EventArgs e)
        {
            DisableEdit();

            Presenter.Save();

            for (int i = 0; i < ListButtonPanel.Controls.Count; i++)
            {
                ((ListButton)ListButtonPanel.Controls[i]).DisableEditMode();
            }

            if (ListButtonPanel.Controls.Count < 8)
            {
                UpdateButtonsSize(338);
            }
        }
        private void EnableEdit()
        {
            EditUsersButton.Click -= EditUsersButton_Click;
            EditUsersButton.Click += new EventHandler(SaveUsersButton_Click);
            EditUsersButton.Text = "Save";
            EditUsersButton.Image = Resources.ImageService.SaveButtonIcon;

            AddUserButton.Click -= AddUserButton_Click;
            AddUserButton.Click += new EventHandler(CancelUsersButton_Click);
            AddUserButton.Text = "Cancel";
            AddUserButton.Image = Resources.ImageService.CancelButtonIcon;
        }
        private void DisableEdit()
        {
            EditUsersButton.Click -= SaveUsersButton_Click;
            EditUsersButton.Click += new EventHandler(EditUsersButton_Click);
            EditUsersButton.Text = "Edit User";
            EditUsersButton.Image = Resources.ImageService.EditButtonIcon;

            AddUserButton.Click -= CancelUsersButton_Click;
            AddUserButton.Click += new EventHandler(AddUserButton_Click);
            AddUserButton.Text = "Add User";
            AddUserButton.Image = Resources.ImageService.AddButtonIcon;
        }
        private void UpdateButtonsSize(int changedSize)
        {
            for (int i = 0; i < ListButtonPanel.Controls.Count; i++)
            {
                ListButtonPanel.Controls[i].Width = changedSize;
            }
        }
        public UserPresenter Presenter
        {
            private get;
            set;
        }
    }
}
