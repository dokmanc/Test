using System;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PGP
{
    public partial class EditorForm : DockContent
    {
        private readonly MainForm formMain;
        private bool encrypted = false;
        private string filePath;
        private bool dirtyFlag = false;

        public EditorForm()
        {
            InitializeComponent();
        }

        public EditorForm(MainForm formMain, string filePath)
        {
            InitializeComponent();

            this.formMain = formMain;
            this.filePath = filePath;
            var fileInfo = new FileInfo(filePath);
            this.TabText = fileInfo.Name;
            this.ToolTipText = filePath;
            string text = File.ReadAllText(filePath);

            this.encrypted = PgpEncryption.IsPgpEncrypted(text);

            if (encrypted)
            {
                try
                {
                    txtEditor.Text = PgpEncryption.DecryptText(text, ApplicationSettings.PrivateKeyPath, ApplicationSettings.PassPhrase);
                }
                catch (Exception e)
                {
                    txtEditor.Text = e.Message;
                }
            }
            else
            {
                txtEditor.Text = text;
            }

            this.dirtyFlag = false;
        }

        private void Editor_Load(object sender, EventArgs e)
        {

        }

        public void Save()
        {
            string encryptedText;

            try
            {
                encryptedText = PgpEncryption.EncryptText(txtEditor.Text, ApplicationSettings.PublicKeyPath, true, true);
            }
            catch (Exception exception)
            {

                MessageBox.Show($"Unable to encrypt file: {exception.Message}");
                return;
            }

            try
            {
                File.WriteAllText(this.filePath, encryptedText);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Unable save encrypt file '{this.filePath}': {exception.Message}");
                return;
            }

            this.dirtyFlag = false;
        }

        private void txtEditor_TextChanged(object sender, EventArgs e)
        {
            this.dirtyFlag = true;
        }

        private void EditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.dirtyFlag)
            {
                DialogResult answer = MessageBox.Show("Do you want to save your changes before closing?", "Document Modified", MessageBoxButtons.YesNoCancel);

                if (answer == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }

                if (answer == DialogResult.Yes)
                {
                    this.Save();
                }

                e.Cancel = false;
            }
        }
    }
}
