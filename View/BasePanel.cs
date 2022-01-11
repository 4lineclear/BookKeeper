using BookKeeper.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookKeeper.View
{
    public class BasePanel<T,U,V> : UserControl, IPanel<T> 
        where T : Model.Items.BaseItem 
        where U : Model.Items.BaseItem
        where V : Model.Items.BaseItem
    {
        public void AddItemButton_Click(object sender, EventArgs e)
        {
            BasePopupForm<T> popup = new BasePopupForm<T>("Create User", "Username");
            Presenter.Add(popup);
            if (ListButtonPanel.Controls.Count > 8)
            {
                UpdateButtonsSize(320);
                ListButtonPanel.AutoScroll = true;
            }
        }
        public void CancelEditButton_Click(object sender, EventArgs e)
        {
            Presenter.RemakeItems();

            DisableEdit();

            if (ListButtonPanel.Controls.Count < 8)
            {
                UpdateButtonsSize(338);
            }
        }
        public void EditItemsButton_Click(object sender, EventArgs e)
        {
            EnableEdit();

            for (int i = 0; i < ListButtonPanel.Controls.Count; i++)
            {
                ((BaseListButton<T, U, V>)ListButtonPanel.Controls[i]).EnableEditMode();
            }
        }
        public void SaveBookListsButton_Click(object sender, EventArgs e)
        {
            DisableEdit();

            Presenter.Save();

            for (int i = 0; i < ListButtonPanel.Controls.Count; i++)
            {
                ((BaseListButton<T, U, V>)ListButtonPanel.Controls[i]).DisableEditMode();
            }

            if (ListButtonPanel.Controls.Count < 8)
            {
                UpdateButtonsSize(338);
            }
        }
        public void EnableEdit()
        {
            EditItemsButton.Click -= EditItemsButton_Click;
            EditItemsButton.Click += new EventHandler(SaveBookListsButton_Click);
            EditItemsButton.Text = "Save";
            EditItemsButton.Image = Resources.ImageService.SaveButtonIcon;

            AddItemButton.Click -= AddItemButton_Click;
            AddItemButton.Click += new EventHandler(CancelEditButton_Click);
            AddItemButton.Text = "Cancel";
            AddItemButton.Image = Resources.ImageService.CancelButtonIcon;
        }
        public void DisableEdit()
        {
            EditItemsButton.Click -= SaveBookListsButton_Click;
            EditItemsButton.Click += new EventHandler(EditItemsButton_Click);
            EditItemsButton.Text = "Edit User";
            EditItemsButton.Image = Resources.ImageService.EditButtonIcon;

            AddItemButton.Click -= CancelEditButton_Click;
            AddItemButton.Click += new EventHandler(AddItemButton_Click);
            AddItemButton.Text = "Add User";
            AddItemButton.Image = Resources.ImageService.AddButtonIcon;
        }
        public void UpdateButtonsSize(int changedSize)
        {
            for (int i = 0; i < ListButtonPanel.Controls.Count; i++)
            {
                ListButtonPanel.Controls[i].Width = changedSize;
            }
        }
        public int GetButtonIndex(BaseListButton<T, U, V> button)
            => ListButtonPanel.Controls.IndexOf(button);
        public void RemoveButton(BaseListButton<T, U, V> button)
            => ListButtonPanel.Controls.Remove(button);
        public void AddButton(BaseListButton<T, U, V> button)
            => ListButtonPanel.Controls.Add(button);
        public void ClearButtons()
            => ListButtonPanel.Controls.Clear();

        public void BackButton_Click(object sender, EventArgs e)
        {
            this.ParentPanel.BringToFront();
        }
        public new virtual void BringToFront()
        {
            base.BringToFront();

        }
        public virtual IPanel<U> ParentPanel { get; set; }
        public virtual IPanel<V> ChildPanel { get; set; }
        public BasePresenter<T,U,V> Presenter { private get; set; }
        public System.Windows.Forms.Button EditItemsButton;
        public System.Windows.Forms.FlowLayoutPanel ListButtonPanel;
        public System.Windows.Forms.Button AddItemButton;
    }
}
