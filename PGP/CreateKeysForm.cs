using System;
using System.Windows.Forms;

namespace PGP
{
    public partial class CreateKeysForm : Form
    {
        public CreateKeysForm()
        {
            InitializeComponent();
        }

        public string Email
        {
            get { return EmailTextbox.Text; }
        }

        public string PassPhrase
        {
            get
            {
                return PassPhraseTextbox.Text;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void PassPhraseText_TextChanged(object sender, EventArgs e)
        {
            EnabledOKButtomCheck();
        }

        private void EnabledOKButtomCheck()
        {
            OkButton.Enabled = EmailTextbox.Text.Trim().Length > 0 && PassPhraseTextbox.Text.Trim().Length > 0;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CreateKeysForm_Load(object sender, EventArgs e)
        {
            
        }

        private void EmailTextbox_TextChanged(object sender, EventArgs e)
        {
            EnabledOKButtomCheck();
        }
    }
}
