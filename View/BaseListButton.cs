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
using static System.Windows.Forms.Control;

namespace BookKeeper.View
{
    public class BaseListButton<T,U,V> : Button, IListButton<T>
        where T : Model.Items.BaseItem
        where U : Model.Items.BaseItem
        where V : Model.Items.BaseItem
    {
        public BaseListButton(BaseItem item, Size size, BasePresenter<T,U,V> presenter)
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
            this.DeleteButton.Name = "DeleteButton";
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
            this.EditButton.Name = "EditButton";
            this.EditButton.Click += new EventHandler(EditButton_Click);
            //
            // ListButton(this)
            //
            this.AutoSize = false;
            this.Click += new EventHandler(ListButton_Click);
            this.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            this.Location = new Point(3, 3);
            this.Name = item.Name + "Button";
            this.Size = size;
            this.Text = item.Name;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UseVisualStyleBackColor = true;
            this.Controls.Add(EditButton);
            this.Controls.Add(DeleteButton);
            this.Name = "ListButton";
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
            this.Presenter.Remove(this);
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Presenter.EditItem(this);
        }
        private void ListButton_Click(object sender, EventArgs e)
        {
            ((UserPanel)this.Parent.Parent.Parent).ChildPanel.BringToFront();
        }

        private readonly Button DeleteButton;

        private readonly Button EditButton;

        public BasePresenter<T,U,V> Presenter;
    }
}
