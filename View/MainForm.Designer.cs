using BookKeeper.Model.Items;

namespace BookKeeper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainUserPanel = new BookKeeper.View.UserPanel();
            this.MainBookListPanel = new BookKeeper.View.BookListPanel();
            this.SuspendLayout();
            // 
            // MainBookListPanel
            // 
            this.MainBookListPanel.ParentPanel = MainUserPanel;
            this.MainBookListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainBookListPanel.Location = new System.Drawing.Point(0, 0);
            this.MainBookListPanel.Name = "MainBookListPanel";
            this.MainBookListPanel.Size = new System.Drawing.Size(704, 681);
            this.MainBookListPanel.TabIndex = 0;
            // 
            // MainUserPanel
            // 
            this.MainUserPanel.ChildPanel = MainBookListPanel;
            this.MainUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainUserPanel.Location = new System.Drawing.Point(0, 0);
            this.MainUserPanel.Name = "MainUserPanel";
            this.MainUserPanel.Size = new System.Drawing.Size(704, 681);
            this.MainUserPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.MainUserPanel);
            this.Controls.Add(this.MainBookListPanel);
            this.Name = "MainForm";
            this.Text = "Book Keeper";
            this.ResumeLayout(false);

        }

        #endregion

        public BookKeeper.View.BookListPanel MainBookListPanel;
        public BookKeeper.View.UserPanel MainUserPanel;
    }
}

