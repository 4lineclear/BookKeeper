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
    public partial class PopupForm : Form
    {
        private bool confirmAction = false;
        public PopupForm()
        {
            InitializeComponent();
        }
        public PopupForm(string popupLabelText, string textboxLabelText)
            : this()
        {
            this.Text = popupLabelText;
            this.PopupLabel.Text = popupLabelText;
            this.TextBoxLabel.Text = textboxLabelText;

            this.ShowDialog();
        }
        public PopupForm(string popupLabelText, string textboxLabelText, string textboxText)
            : this()
        {
            this.Text = popupLabelText;
            this.PopupLabel.Text = popupLabelText;
            this.TextBoxLabel.Text = textboxLabelText;
            this.PopupTextBox.Text = textboxText;

            this.ShowDialog();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            confirmAction = false;
            this.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            confirmAction = true;
            this.Close();
        }
        public bool OutputText(out string text)
        {
            text = PopupTextBox.Text;
            return confirmAction && !string.IsNullOrWhiteSpace(text);
        }
    }
}
