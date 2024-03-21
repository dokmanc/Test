using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGP.Forms
{
    public partial class EncryptFileForm : Form
    {
        public EncryptFileForm()
        {
            InitializeComponent();
        }

        private void EncryptFileForm_Load(object sender, EventArgs e)
        {
            PopulateSendToDropdown();
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

        private void SendToDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            OkButton.Enabled = SendToDropdown.SelectedIndex != -1;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private int myVar;

        public SendToItem SelectedRecipient
        {
            get
            {
                return (SendToItem)SendToDropdown.SelectedItem;                
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
