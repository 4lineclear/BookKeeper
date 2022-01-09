
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
            this.MainMenuPanel = new View.TablePanelNode();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.EditUsersButton = new System.Windows.Forms.Button();
            this.MainMenuTitle = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.MainMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.ColumnCount = 4;
            this.MainMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainMenuPanel.Controls.Add(this.SettingsButton, 0, 8);
            this.MainMenuPanel.Controls.Add(this.EditUsersButton, 3, 8);
            this.MainMenuPanel.Controls.Add(this.MainMenuTitle, 0, 0);
            this.MainMenuPanel.Controls.Add(this.UserLabel, 2, 2);
            this.MainMenuPanel.Controls.Add(this.UserFlowLayoutPanel, 2, 3);
            this.MainMenuPanel.Controls.Add(this.AddUserButton, 2, 8);
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.RowCount = 9;
            this.MainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11005F));
            this.MainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11005F));
            this.MainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11005F));
            this.MainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11005F));
            this.MainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11005F));
            this.MainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11005F));
            this.MainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11227F));
            this.MainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.1137F));
            this.MainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.1137F));
            this.MainMenuPanel.Size = new System.Drawing.Size(704, 681);
            this.MainMenuPanel.TabIndex = 1;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.EditUsersButton.Location = new System.Drawing.Point(531, 603);
            this.EditUsersButton.Name = "EditUsersButton";
            this.EditUsersButton.Size = new System.Drawing.Size(170, 75);
            this.EditUsersButton.TabIndex = 4;
            this.EditUsersButton.Text = "Edit Users";
            this.EditUsersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditUsersButton.UseVisualStyleBackColor = true;
            this.EditUsersButton.Click += new System.EventHandler(this.EditUsersButton_Click);
            // 
            // MainMenuTitle
            // 
            this.MainMenuTitle.AutoSize = true;
            this.MainMenuPanel.SetColumnSpan(this.MainMenuTitle, 4);
            this.MainMenuTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuTitle.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuTitle.Location = new System.Drawing.Point(3, 0);
            this.MainMenuTitle.Name = "MainMenuTitle";
            this.MainMenuPanel.SetRowSpan(this.MainMenuTitle, 2);
            this.MainMenuTitle.Size = new System.Drawing.Size(698, 150);
            this.MainMenuTitle.TabIndex = 0;
            this.MainMenuTitle.Text = "Book Keeper";
            this.MainMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // UserFlowLayoutPanel
            // 
            this.UserFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainMenuPanel.SetColumnSpan(this.UserFlowLayoutPanel, 2);
            this.UserFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.UserFlowLayoutPanel.Location = new System.Drawing.Point(355, 228);
            this.UserFlowLayoutPanel.Name = "UserFlowLayoutPanel";
            this.MainMenuPanel.SetRowSpan(this.UserFlowLayoutPanel, 5);
            this.UserFlowLayoutPanel.Size = new System.Drawing.Size(346, 369);
            this.UserFlowLayoutPanel.TabIndex = 2;
            this.UserFlowLayoutPanel.WrapContents = false;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddUserButton.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.Controls.Add(this.MainMenuPanel);
            this.Name = "UserPanel";
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private View.TablePanelNode MainMenuPanel;
        private System.Windows.Forms.Label MainMenuTitle;
        private System.Windows.Forms.Button EditUsersButton;
        private System.Windows.Forms.Label UserLabel;
        public System.Windows.Forms.FlowLayoutPanel UserFlowLayoutPanel;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button SettingsButton;
    }
}
