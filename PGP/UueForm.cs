using PGP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PGP
{
    public partial class UueForm : DockContent
    {
        MainForm mainForm;

        public UueForm()
        {
            InitializeComponent();
        }

        public UueForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputFilePath = @"D:\Users\Chad\Desktop\UueTest\PGP.zip";
            FileInfo fileInfo = new FileInfo(inputFilePath);
            string uueBaseName = $"{fileInfo.Name}.uue";
            string outputDirectory = Path.Combine(fileInfo.DirectoryName, uueBaseName); // Directory to store uuencoded files
            Directory.CreateDirectory(outputDirectory);

            //UuEncoding.UuEncode(inputFilePath, outputDirectory, 1024 * 2); //2 MB

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //RebuildFromUuEncoded(startFilePath, outputFolder);
        }

    }
}
