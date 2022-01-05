using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookKeeper.Model.Items;
using BookKeeper.Presenters;

namespace BookKeeper.View
{
    public class ListButton : Button
    {
        public int ID;
        public ListButton(UserItem item, Size size, UserPresenter presenter)
        {
            this.Presenter = presenter;
            //
            // DeleteButton
            //
            this.DeleteButton = new Button();
            this.DeleteButton.Size = new Size(40,40);
            this.DeleteButton.Image = Resources.ImageService.ListButtonDeleteIcon; ;
            this.DeleteButton.ImageAlign = ContentAlignment.MiddleCenter;
            this.DeleteButton.Dock = DockStyle.Right;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new EventHandler(DeleteButton_Click);
            //
            // EditButton
            //
            this.EditButton = new Button();
            this.EditButton.Size = new Size(40, 40);
            this.EditButton.Image = Resources.ImageService.ListButtonEditIcon;
            this.EditButton.ImageAlign = ContentAlignment.MiddleCenter;
            this.EditButton.Dock = DockStyle.Right;
            this.EditButton.Visible = false;
            this.EditButton.Click += new EventHandler(EditButton_Click);
            //
            // ListButton(this)
            //
            this.AutoSize = false;
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Location = new System.Drawing.Point(3, 3);
            this.Name = item.Name + "Button";
            this.Size = size;
            this.Text = item.Name;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UseVisualStyleBackColor = true;
            this.Controls.Add(EditButton);
            this.Controls.Add(DeleteButton);
            this.ID = item.ID;
        }
        public void EnableEditMode()
        {
            DeleteButton.Visible = true;
            EditButton.Visible = true;
        }
        public void DisableEditMode()
        {
            DeleteButton.Visible = false;
            EditButton.Visible = false;
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.Presenter.Remove(this.ID);
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            Presenter.EditItem(this.ID);
        }
        public override string ToString()
        {
            return $"Text:{this.Text} TabIndex:{this.TabIndex} ID:{this.ID}";
        }

        private readonly Button DeleteButton;

        private readonly Button EditButton;

        public UserPresenter Presenter;
    }
}
