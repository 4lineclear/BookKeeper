
namespace BookKeeper.View
{
    partial class PopupForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PopupGridLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PopupConfirmButton = new System.Windows.Forms.Button();
            this.PopupLabel = new System.Windows.Forms.Label();
            this.PopupTextBox = new System.Windows.Forms.TextBox();
            this.TextBoxLabel = new System.Windows.Forms.Label();
            this.PopupCancelButton = new System.Windows.Forms.Button();
            this.PopupGridLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PopupGridLayoutPanel
            // 
            this.PopupGridLayoutPanel.ColumnCount = 6;
            this.PopupGridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66708F));
            this.PopupGridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66709F));
            this.PopupGridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66709F));
            this.PopupGridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66542F));
            this.PopupGridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.PopupGridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.PopupGridLayoutPanel.Controls.Add(this.PopupConfirmButton, 3, 3);
            this.PopupGridLayoutPanel.Controls.Add(this.PopupLabel, 0, 0);
            this.PopupGridLayoutPanel.Controls.Add(this.PopupTextBox, 2, 1);
            this.PopupGridLayoutPanel.Controls.Add(this.TextBoxLabel, 0, 1);
            this.PopupGridLayoutPanel.Controls.Add(this.PopupCancelButton, 1, 3);
            this.PopupGridLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PopupGridLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.PopupGridLayoutPanel.Name = "PopupGridLayoutPanel";
            this.PopupGridLayoutPanel.RowCount = 4;
            this.PopupGridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.PopupGridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.PopupGridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.PopupGridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.PopupGridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PopupGridLayoutPanel.Size = new System.Drawing.Size(304, 181);
            this.PopupGridLayoutPanel.TabIndex = 0;
            // 
            // PopupConfirmButton
            // 
            this.PopupGridLayoutPanel.SetColumnSpan(this.PopupConfirmButton, 2);
            this.PopupConfirmButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PopupConfirmButton.Location = new System.Drawing.Point(153, 138);
            this.PopupConfirmButton.Name = "PopupConfirmButton";
            this.PopupConfirmButton.Size = new System.Drawing.Size(94, 40);
            this.PopupConfirmButton.TabIndex = 4;
            this.PopupConfirmButton.Text = "Confirm";
            this.PopupConfirmButton.UseVisualStyleBackColor = true;
            this.PopupConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // PopupLabel
            // 
            this.PopupLabel.AutoSize = true;
            this.PopupGridLayoutPanel.SetColumnSpan(this.PopupLabel, 6);
            this.PopupLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PopupLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PopupLabel.Location = new System.Drawing.Point(3, 0);
            this.PopupLabel.Name = "PopupLabel";
            this.PopupLabel.Size = new System.Drawing.Size(298, 45);
            this.PopupLabel.TabIndex = 0;
            this.PopupLabel.Text = "LabelText";
            this.PopupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PopupTextBox
            // 
            this.PopupGridLayoutPanel.SetColumnSpan(this.PopupTextBox, 3);
            this.PopupTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PopupTextBox.Location = new System.Drawing.Point(103, 64);
            this.PopupTextBox.Name = "PopupTextBox";
            this.PopupTextBox.Size = new System.Drawing.Size(144, 23);
            this.PopupTextBox.TabIndex = 1;
            // 
            // TextBoxLabel
            // 
            this.TextBoxLabel.AutoSize = true;
            this.PopupGridLayoutPanel.SetColumnSpan(this.TextBoxLabel, 2);
            this.TextBoxLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBoxLabel.Location = new System.Drawing.Point(6, 69);
            this.TextBoxLabel.Margin = new System.Windows.Forms.Padding(6);
            this.TextBoxLabel.Name = "TextBoxLabel";
            this.TextBoxLabel.Size = new System.Drawing.Size(88, 15);
            this.TextBoxLabel.TabIndex = 2;
            this.TextBoxLabel.Text = "LabelText";
            this.TextBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PopupCancelButton
            // 
            this.PopupGridLayoutPanel.SetColumnSpan(this.PopupCancelButton, 2);
            this.PopupCancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PopupCancelButton.Location = new System.Drawing.Point(53, 138);
            this.PopupCancelButton.Name = "PopupCancelButton";
            this.PopupCancelButton.Size = new System.Drawing.Size(94, 40);
            this.PopupCancelButton.TabIndex = 3;
            this.PopupCancelButton.Text = "Cancel";
            this.PopupCancelButton.UseVisualStyleBackColor = true;
            this.PopupCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PopupForm
            // 
            this.AcceptButton = this.PopupConfirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.PopupCancelButton;
            this.ClientSize = new System.Drawing.Size(304, 181);
            this.Controls.Add(this.PopupGridLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopupForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Popup";
            this.PopupGridLayoutPanel.ResumeLayout(false);
            this.PopupGridLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PopupGridLayoutPanel;
        private System.Windows.Forms.Button PopupConfirmButton;
        private System.Windows.Forms.Label PopupLabel;
        private System.Windows.Forms.TextBox PopupTextBox;
        private System.Windows.Forms.Label TextBoxLabel;
        private System.Windows.Forms.Button PopupCancelButton;
    }
}