using PGP.Classes;
using PGP.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PGP
{
    public partial class MainForm : Form
    {

        static string ComcastPassword = "?"; //sensitive

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenNewPgpForm();

            //OpenNewUueForm();

        }

        private void OpenNewPgpForm()
        {
            var pgpForm = new PgpForm(this);
            pgpForm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        }

        private void myKeyFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ApplicationSettings.KeyFilesExist())
            {
                var answer = MessageBox.Show("You have no key files yet. Would you like to generate them now?", "Generate Key Files", MessageBoxButtons.OKCancel);

                if (answer == DialogResult.OK)
                {
                    GenerateKeyFiles();
                }

                return;
            }


            FileInfo fileInfo = new FileInfo(ApplicationSettings.PrivateKeyPath);
            Process.Start("explorer.exe", fileInfo.Directory.FullName);
        }

        private void viewRecipientKeyFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", ApplicationSettings.SendToFolder);
        }

        private void generateMyKeyFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateKeyFiles();
        }

        private void GenerateKeyFiles()
        {
            if (ApplicationSettings.KeyFilesExist())
            {
                DialogResult answer = MessageBox.Show("Do you want to overwrite your existing key files?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (answer == DialogResult.Cancel)
                {
                    return;
                }
            }

            var createKeysForm = new CreateKeysForm();

            if (createKeysForm.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            PgpEncryption.GenerateKey
                (
                ApplicationSettings.PublicKeyPath,
                ApplicationSettings.PrivateKeyPath,
                createKeysForm.Email,
                createKeysForm.PassPhrase
                );

            MessageBox.Show("Send your public key to person to whom you wish to converse", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            this.Close();
        }

        private void CloseAllForms()
        {

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOpenFileDialog();
        }

        private void ShowOpenFileDialog()
        {

            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }

            var editor = new EditorForm(this, openFileDialog1.FileName);
            editor.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void SaveDocument()
        {
            foreach (var currentDocument in this.dockPanel1.Documents)
            {
                if (currentDocument is EditorForm editorForm && currentDocument == this.dockPanel1.ActiveDocument)
                {
                    editorForm.Save();
                }
            }
        }

        private void pGPEncryptDecryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewPgpForm();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            ShowOpenFileDialog();
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void uUEEncodingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Email.ReadComcastMail();
            string senderEmail = "chaddokmanovich@comcast.net";
            string password = ComcastPassword;
            string recipientEmail = "chaddokmanovich@gmail.com";
            string startFile = @"D:\Users\Chad\Desktop\UUE\Aerosmith-ToysInTheAttic-GuitarBackingTrack.mp3-1.uuee";

            Email.SendUsingComcast(startFile, senderEmail, password, recipientEmail);
        }

        private void OpenNewUueForm()
        {
            var uueForm = new UueForm(this);
            uueForm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        }

        private void encodeAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a file to UU Encode:";

            var dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {

                EncryptFileForm encryptFileForm = new EncryptFileForm();
                var recipientResult = encryptFileForm.ShowDialog();

                if (recipientResult == DialogResult.Cancel)
                {
                    return;
                }

                //string recipientPublicKey = ((SendToItem)SendToDropdown.SelectedItem).FileName;
                SendToItem recipient = encryptFileForm.SelectedRecipient;

                Cursor.Current = Cursors.WaitCursor;

                FileInfo sourceFileInfo = new FileInfo(openFileDialog.FileName);

                folderBrowserDialog1 = new FolderBrowserDialog();
                folderBrowserDialog1.Description = "Select the output location to save the encoded files:";
                folderBrowserDialog1.SelectedPath = sourceFileInfo.Directory.FullName;
                DialogResult result = folderBrowserDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                  //UuEncoding.UuEncode(openFileDialog.FileName, folderBrowserDialog1.SelectedPath, 324, ApplicationSettings.PublicKeyPath);
                    UuEncoding.UuEncode(openFileDialog.FileName, folderBrowserDialog1.SelectedPath, 324, recipient.FileName);
                    Cursor.Current = Cursors.Default;

                    var seeFiles = MessageBox.Show("Would you like to navigate to open the output folder?", "Open Output", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (seeFiles == DialogResult.Yes)
                    {
                        WindowsUtilities.OpenFolderInWindowsExplorer(folderBrowserDialog1.SelectedPath);
                    }
                }
            }
        }

        private void rebuildFromEncodedFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "First UUE File (*-1.uue)|*-1.uue|All Files (*.*)|*.*";
            openFileDialog.Filter = "First UUE File (*-1.uue)|*-1.uue|First UUEE File (*-1.uuee)|*-1.uuee|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1; // Select the "*.uue" filter by default
            openFileDialog.Title = "Select the first UU Encoded File";  

            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                FileInfo selectedFileInfo = new FileInfo(openFileDialog.FileName);
                string outputFolder = selectedFileInfo.DirectoryName;

                try
                {
                    string outputFile = UuEncoding.RebuildFromUuEncoded(openFileDialog.FileName, outputFolder, ApplicationSettings.PrivateKeyPath, ApplicationSettings.PassPhrase);
                    WindowsUtilities.ShowFileInWindowsExplorer(outputFile);
                }
                catch (Exception)
                {

                    throw;
                }
                
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
