using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGP
{
    public partial class VerifyForm : Form
    {
        public string PassPhrase
        {
            get { return PassPhraseText.Text; }
        }

        public VerifyForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void PassPhraseText_TextChanged(object sender, EventArgs e)
        {
            OkButton.Enabled = PassPhraseText.Text.Trim().Length > 0;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(ApplicationSettings.PassPhasePath))
            {
                var createPassFile = MessageBox.Show("Do you want to save this PassPhrase locally so you don't have to reenter it in the future?", "Save Pass Phrase?", MessageBoxButtons.YesNo);
                
                if (createPassFile == DialogResult.Yes)
                {
                    System.IO.File.WriteAllText(ApplicationSettings.PassPhasePath, PassPhraseText.Text);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void VerifyForm_Load(object sender, EventArgs e)
        {
            PassPhraseText.Text = ApplicationSettings.PassPhrase;
        }
    }

}
