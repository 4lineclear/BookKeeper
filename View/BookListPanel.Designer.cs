
namespace BookKeeper.View
{
    partial class BookListPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EditItemsButton = new System.Windows.Forms.Button();
            this.MainTitle = new System.Windows.Forms.Label();
            this.BookListLabel = new System.Windows.Forms.Label();
            this.ListButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 4;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainPanel.Controls.Add(this.BackButton, 0, 8);
            this.MainPanel.Controls.Add(this.EditItemsButton, 3, 8);
            this.MainPanel.Controls.Add(this.MainTitle, 0, 0);
            this.MainPanel.Controls.Add(this.BookListLabel, 2, 2);
            this.MainPanel.Controls.Add(this.ListButtonPanel, 2, 3);
            this.MainPanel.Controls.Add(this.AddItemButton, 2, 8);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 9;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11005F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11005F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11005F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11005F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11005F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11005F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11227F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.1137F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.1137F));
            this.MainPanel.Size = new System.Drawing.Size(704, 681);
            this.MainPanel.TabIndex = 1;
            // 
            // EditItemsButton
            // 
            this.EditItemsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditItemsButton.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditItemsButton.Image = Resources.ImageService.EditButtonIcon;
            this.EditItemsButton.Location = new System.Drawing.Point(531, 603);
            this.EditItemsButton.Name = "EditItemsButton";
            this.EditItemsButton.Size = new System.Drawing.Size(170, 75);
            this.EditItemsButton.TabIndex = 4;
            this.EditItemsButton.Text = "Edit Lists";
            this.EditItemsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditItemsButton.UseVisualStyleBackColor = true;
            this.EditItemsButton.Click += new System.EventHandler(this.EditItemsButton_Click);
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.MainTitle, 4);
            this.MainTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTitle.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainTitle.Location = new System.Drawing.Point(3, 0);
            this.MainTitle.Name = "MainTitle";
            this.MainPanel.SetRowSpan(this.MainTitle, 2);
            this.MainTitle.Size = new System.Drawing.Size(698, 150);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "Book Keeper";
            this.MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookListLabel
            // 
            this.BookListLabel.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.BookListLabel, 2);
            this.BookListLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BookListLabel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookListLabel.Location = new System.Drawing.Point(355, 153);
            this.BookListLabel.Name = "BookListLabel";
            this.BookListLabel.Size = new System.Drawing.Size(346, 72);
            this.BookListLabel.TabIndex = 1;
            this.BookListLabel.Text = "Book List";
            // 
            // ListButtonPanel
            // 
            this.ListButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.SetColumnSpan(this.ListButtonPanel, 2);
            this.ListButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListButtonPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ListButtonPanel.Location = new System.Drawing.Point(355, 228);
            this.ListButtonPanel.Name = "ListButtonPanel";
            this.MainPanel.SetRowSpan(this.ListButtonPanel, 5);
            this.ListButtonPanel.Size = new System.Drawing.Size(346, 369);
            this.ListButtonPanel.TabIndex = 2;
            this.ListButtonPanel.WrapContents = false;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddItemButton.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddItemButton.Image = Resources.ImageService.AddButtonIcon;
            this.AddItemButton.Location = new System.Drawing.Point(355, 603);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(170, 75);
            this.AddItemButton.TabIndex = 3;
            this.AddItemButton.Text = "Add List";
            this.AddItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Image = Resources.ImageService.BackButtonIcon;
            this.BackButton.Location = new System.Drawing.Point(3, 603);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(170, 75);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BookListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ChildPanel = this;
            this.Controls.Add(this.MainPanel);
            this.Name = "BookListPanel";
            this.Size = new System.Drawing.Size(704, 681);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Label BookListLabel;
        private System.Windows.Forms.Button BackButton;
    }
}
