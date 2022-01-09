
namespace BookKeeper.View
{
    partial class UserPanel
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
            this.MainPanel = new View.TablePanelNode();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.EditUsersButton = new System.Windows.Forms.Button();
            this.MainTitle = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.ListButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddUserButton = new System.Windows.Forms.Button();
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
            this.MainPanel.Controls.Add(this.SettingsButton, 0, 8);
            this.MainPanel.Controls.Add(this.EditUsersButton, 3, 8);
            this.MainPanel.Controls.Add(this.MainTitle, 0, 0);
            this.MainPanel.Controls.Add(this.UserLabel, 2, 2);
            this.MainPanel.Controls.Add(this.ListButtonPanel, 2, 3);
            this.MainPanel.Controls.Add(this.AddUserButton, 2, 8);
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
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsButton.Image = Resources.ImageService.SettingsButtonIcon;
            this.SettingsButton.Location = new System.Drawing.Point(3, 603);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(170, 75);
            this.SettingsButton.TabIndex = 6;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // EditUsersButton
            // 
            this.EditUsersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditUsersButton.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditUsersButton.Image = Resources.ImageService.EditButtonIcon;
            this.EditUsersButton.Location = new System.Drawing.Point(531, 603);
            this.EditUsersButton.Name = "EditUsersButton";
            this.EditUsersButton.Size = new System.Drawing.Size(170, 75);
            this.EditUsersButton.TabIndex = 4;
            this.EditUsersButton.Text = "Edit Users";
            this.EditUsersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditUsersButton.UseVisualStyleBackColor = true;
            this.EditUsersButton.Click += new System.EventHandler(this.EditUsersButton_Click);
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
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserLabel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserLabel.Location = new System.Drawing.Point(355, 153);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(170, 72);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "User";
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
            // AddUserButton
            // 
            this.AddUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddUserButton.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddUserButton.Image = Resources.ImageService.AddButtonIcon;
            this.AddUserButton.Location = new System.Drawing.Point(355, 603);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(170, 75);
            this.AddUserButton.TabIndex = 3;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.MainPanel);
            this.Name = "UserPanel";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private View.TablePanelNode MainPanel;
        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Button EditUsersButton;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.FlowLayoutPanel ListButtonPanel;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button SettingsButton;
    }
}
