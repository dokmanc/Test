using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PGP
{
    public partial class PgpForm : DockContent
    {
        private readonly string privateKey;
        private readonly string publicKey;
        private bool providedPassPhraseMemoryCache = false;
        private string PassPhraseMemoryCache = "";
        private readonly MainForm mainForm;

        public PgpForm()
        {
            InitializeComponent();
        }

        public PgpForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            privateKey = ApplicationSettings.PrivateKeyPath;
            publicKey = ApplicationSettings.PublicKeyPath;
            PopulateSendToDropdown();
        }


        private void cmdEncrypt_Click(object sender, EventArgs e)
        {
            if (!ApplicationSettings.KeyFilesExist())
            {
                MessageBox.Show("You must first generate your Public and Private key files.", "Setup Required First");
                return;
            }

            if (SendToDropdown.SelectedItem == null)
            {
                MessageBox.Show("Select a message recipient", "No Recipient Secified", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SendToDropdown.Focus();
                return;
            }

            string recipientPublicKey = ((SendToItem)SendToDropdown.SelectedItem).FileName;
            string tempPath = Path.GetTempPath();
            string inClearTextPath = Path.Combine(tempPath, "InClearText.txt");
            string outEncryptePath = Path.Combine(tempPath, "OutEncrypted.txt");

            File.WriteAllText(inClearTextPath, txtInClearText.Text);
            PgpEncryption.EncryptFile(inClearTextPath, outEncryptePath, recipientPublicKey, true, true);
            txtOutEncrypted.Text = File.ReadAllText(outEncryptePath);

            File.Delete(inClearTextPath);
            File.Delete(outEncryptePath);
        }

        private void cmdDecrypt_Click(object sender, EventArgs e)
        {
            if (!ApplicationSettings.KeyFilesExist())
            {
                MessageBox.Show("You must first generate your Public and Private key files.", "Setup Required First");
                return;
            }

            string tempPath = Path.GetTempPath();
            string inEncryptedPath = Path.Combine(tempPath, "InEncrypted.txt");
            string outClearTextPath = Path.Combine(tempPath, "OutClearText.txt");

            if (!this.providedPassPhraseMemoryCache)
            {
                string savedPassPhraseFromFile = ApplicationSettings.PassPhrase;

                if (string.IsNullOrEmpty(savedPassPhraseFromFile))
                {
                    txtOutClearText.Text = "";
                    VerifyForm verifyForm = new VerifyForm();
                    verifyForm.ShowDialog(this);

                    if (verifyForm.DialogResult != DialogResult.OK)
                    {
                        return;
                    }

                    this.PassPhraseMemoryCache = verifyForm.PassPhrase;
                }
                else
                {
                    this.PassPhraseMemoryCache = savedPassPhraseFromFile;
                    this.providedPassPhraseMemoryCache = true;
                }
            }

            File.WriteAllText(inEncryptedPath, txtInEncrypted.Text);

            try
            {
                PgpEncryption.DecryptFile(inEncryptedPath, outClearTextPath, this.privateKey, this.PassPhraseMemoryCache);
                txtOutClearText.Text = File.ReadAllText(outClearTextPath);
                this.providedPassPhraseMemoryCache = true;
            }
            catch
            {
                txtOutClearText.Text = "Decryption Failed";
            }
            finally
            {
                File.Delete(inEncryptedPath);
                File.Delete(outClearTextPath);
            }
        }

        private void txtInEncrypted_TextChanged(object sender, EventArgs e)
        {
            txtOutClearText.Text = "";
        }

        private void txtInEncrypted_Enter(object sender, EventArgs e)
        {
            txtInEncrypted.SelectAll();
        }

        private void txtInClearText_Enter(object sender, EventArgs e)
        {
            txtInClearText.SelectAll();
        }

        private void txtInClearText_TextChanged(object sender, EventArgs e)
        {
            if (txtOutEncrypted.Text.Length > 0)
            {
                txtOutEncrypted.Text = "";
            }
        }

        private void txtOutClearText_Enter(object sender, EventArgs e)
        {
            txtOutClearText.SelectAll();
        }

        private void PopulateSendToDropdown()
        {
            var sendToMyselfItem = new SendToItem()
            {
                DisplayName = "Myself",
                FileName = ApplicationSettings.PublicKeyPath
            };

            SendToDropdown.Items.Add(sendToMyselfItem);

            string sendToFolderPath = ApplicationSettings.SendToFolder;

            if (!Directory.Exists(sendToFolderPath))
            {
                Directory.CreateDirectory(sendToFolderPath);
            }            

            foreach (string fileName in Directory.GetFiles(sendToFolderPath))
            {
                var sendToItem = new SendToItem()
                {
                    FileName = fileName,
                    DisplayName = Path.GetFileNameWithoutExtension(fileName)
                };

                SendToDropdown.Items.Add(sendToItem);
            }
        }



        private class SendToItem
        {
            public string FileName { get; set; }

            public string DisplayName { get; set; }

            public override string ToString()
            {
                return DisplayName;
            }
        }

        private void SendToDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            providedPassPhraseMemoryCache = false;
            txtInClearText.Focus();
        }

        private void tabPGP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPGP.SelectedTab == tabDecrypt)
            {
                txtInEncrypted.Focus();
            }
            else
            {
                txtInClearText.Focus();
            }
        }

        private void txtOutEncrypted_Enter(object sender, EventArgs e)
        {
            txtOutEncrypted.SelectAll();
        }

        private void CopyEncryptedButton_Click(object sender, EventArgs e)
        {
            if (txtOutEncrypted.Text.Length > 0)
            {
                Clipboard.SetText(txtOutEncrypted.Text);
            }
        }

        private void CopyDecrypted_Click(object sender, EventArgs e)
        {
            if (txtOutClearText.Text.Length > 0)
            {
                Clipboard.SetText(txtOutClearText.Text);
            }
        }
    }
}
