namespace PGP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenFileButton = new System.Windows.Forms.ToolStripButton();
            this.SaveFileButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.myKeyFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecipientKeyFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateMyKeyFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pGPEncryptDecryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uUEEncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uUEncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebuildFromEncodedFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanel1
            // 
            this.dockPanel1.ActiveAutoHideContent = null;
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(1067, 554);
            this.dockPanel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileButton,
            this.SaveFileButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileButton.Image")));
            this.OpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(29, 24);
            this.OpenFileButton.Text = "toolStripButton1";
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveFileButton.Image")));
            this.SaveFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(29, 24);
            this.SaveFileButton.Text = "toolStripButton1";
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.myKeyFilesToolStripMenuItem,
            this.viewRecipientKeyFilesToolStripMenuItem,
            this.generateMyKeyFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFileToolStripMenuItem.Image")));
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.openFileToolStripMenuItem.Text = "Open...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::PGP.Properties.Resources.save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(257, 6);
            // 
            // myKeyFilesToolStripMenuItem
            // 
            this.myKeyFilesToolStripMenuItem.Name = "myKeyFilesToolStripMenuItem";
            this.myKeyFilesToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.myKeyFilesToolStripMenuItem.Text = "View My Key Files...";
            this.myKeyFilesToolStripMenuItem.Click += new System.EventHandler(this.myKeyFilesToolStripMenuItem_Click);
            // 
            // viewRecipientKeyFilesToolStripMenuItem
            // 
            this.viewRecipientKeyFilesToolStripMenuItem.Name = "viewRecipientKeyFilesToolStripMenuItem";
            this.viewRecipientKeyFilesToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.viewRecipientKeyFilesToolStripMenuItem.Text = "View Recipient Key Files...";
            this.viewRecipientKeyFilesToolStripMenuItem.Click += new System.EventHandler(this.viewRecipientKeyFilesToolStripMenuItem_Click);
            // 
            // generateMyKeyFileToolStripMenuItem
            // 
            this.generateMyKeyFileToolStripMenuItem.Name = "generateMyKeyFileToolStripMenuItem";
            this.generateMyKeyFileToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.generateMyKeyFileToolStripMenuItem.Text = "Generate My Key File...";
            this.generateMyKeyFileToolStripMenuItem.Click += new System.EventHandler(this.generateMyKeyFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pGPEncryptDecryptToolStripMenuItem,
            this.uUEEncodingToolStripMenuItem,
            this.uUEncodingToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // pGPEncryptDecryptToolStripMenuItem
            // 
            this.pGPEncryptDecryptToolStripMenuItem.Name = "pGPEncryptDecryptToolStripMenuItem";
            this.pGPEncryptDecryptToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.pGPEncryptDecryptToolStripMenuItem.Text = "PGP Encrypt/Decrypt ";
            this.pGPEncryptDecryptToolStripMenuItem.Click += new System.EventHandler(this.pGPEncryptDecryptToolStripMenuItem_Click);
            // 
            // uUEEncodingToolStripMenuItem
            // 
            this.uUEEncodingToolStripMenuItem.Name = "uUEEncodingToolStripMenuItem";
            this.uUEEncodingToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.uUEEncodingToolStripMenuItem.Text = "Send Email";
            this.uUEEncodingToolStripMenuItem.Click += new System.EventHandler(this.uUEEncodingToolStripMenuItem_Click);
            // 
            // uUEncodingToolStripMenuItem
            // 
            this.uUEncodingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encodeAFileToolStripMenuItem,
            this.rebuildFromEncodedFilesToolStripMenuItem});
            this.uUEncodingToolStripMenuItem.Name = "uUEncodingToolStripMenuItem";
            this.uUEncodingToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.uUEncodingToolStripMenuItem.Text = "UU Encoding";
            // 
            // encodeAFileToolStripMenuItem
            // 
            this.encodeAFileToolStripMenuItem.Name = "encodeAFileToolStripMenuItem";
            this.encodeAFileToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.encodeAFileToolStripMenuItem.Text = "Encode a File";
            this.encodeAFileToolStripMenuItem.Click += new System.EventHandler(this.encodeAFileToolStripMenuItem_Click);
            // 
            // rebuildFromEncodedFilesToolStripMenuItem
            // 
            this.rebuildFromEncodedFilesToolStripMenuItem.Name = "rebuildFromEncodedFilesToolStripMenuItem";
            this.rebuildFromEncodedFilesToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.rebuildFromEncodedFilesToolStripMenuItem.Text = "Rebuild from Encoded Files";
            this.rebuildFromEncodedFilesToolStripMenuItem.Click += new System.EventHandler(this.rebuildFromEncodedFilesToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dockPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "PGP Encryption";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenFileButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myKeyFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecipientKeyFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateMyKeyFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton SaveFileButton;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pGPEncryptDecryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uUEEncodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uUEncodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodeAFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebuildFromEncodedFilesToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}