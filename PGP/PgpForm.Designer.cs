namespace PGP
{
    partial class PgpForm
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
            this.cmdEncrypt = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtInClearText = new System.Windows.Forms.RichTextBox();
            this.CopyEncryptedButton = new System.Windows.Forms.Button();
            this.txtOutEncrypted = new System.Windows.Forms.RichTextBox();
            this.tabPGP = new System.Windows.Forms.TabControl();
            this.tabEncrypt = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.SendToDropdown = new System.Windows.Forms.ComboBox();
            this.tabDecrypt = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cmdDecrypt = new System.Windows.Forms.Button();
            this.txtInEncrypted = new System.Windows.Forms.RichTextBox();
            this.CopyDecrypted = new System.Windows.Forms.Button();
            this.txtOutClearText = new System.Windows.Forms.RichTextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPGP.SuspendLayout();
            this.tabEncrypt.SuspendLayout();
            this.tabDecrypt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdEncrypt
            // 
            this.cmdEncrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdEncrypt.Location = new System.Drawing.Point(0, 0);
            this.cmdEncrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdEncrypt.Name = "cmdEncrypt";
            this.cmdEncrypt.Size = new System.Drawing.Size(67, 249);
            this.cmdEncrypt.TabIndex = 3;
            this.cmdEncrypt.Text = ">>";
            this.cmdEncrypt.UseVisualStyleBackColor = true;
            this.cmdEncrypt.Click += new System.EventHandler(this.cmdEncrypt_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(4, 31);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer1.Size = new System.Drawing.Size(970, 462);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtInClearText
            // 
            this.txtInClearText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInClearText.Location = new System.Drawing.Point(0, 0);
            this.txtInClearText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInClearText.Name = "txtInClearText";
            this.txtInClearText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtInClearText.Size = new System.Drawing.Size(899, 249);
            this.txtInClearText.TabIndex = 2;
            this.txtInClearText.Text = "";
            this.txtInClearText.TextChanged += new System.EventHandler(this.txtInClearText_TextChanged);
            this.txtInClearText.Enter += new System.EventHandler(this.txtInClearText_Enter);
            // 
            // CopyEncryptedButton
            // 
            this.CopyEncryptedButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CopyEncryptedButton.Location = new System.Drawing.Point(0, 0);
            this.CopyEncryptedButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CopyEncryptedButton.Name = "CopyEncryptedButton";
            this.CopyEncryptedButton.Size = new System.Drawing.Size(68, 208);
            this.CopyEncryptedButton.TabIndex = 5;
            this.CopyEncryptedButton.Text = "Copy";
            this.CopyEncryptedButton.UseVisualStyleBackColor = true;
            this.CopyEncryptedButton.Click += new System.EventHandler(this.CopyEncryptedButton_Click);
            // 
            // txtOutEncrypted
            // 
            this.txtOutEncrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutEncrypted.Location = new System.Drawing.Point(0, 0);
            this.txtOutEncrypted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutEncrypted.Name = "txtOutEncrypted";
            this.txtOutEncrypted.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtOutEncrypted.Size = new System.Drawing.Size(898, 208);
            this.txtOutEncrypted.TabIndex = 4;
            this.txtOutEncrypted.Text = "";
            this.txtOutEncrypted.Enter += new System.EventHandler(this.txtOutEncrypted_Enter);
            // 
            // tabPGP
            // 
            this.tabPGP.Controls.Add(this.tabEncrypt);
            this.tabPGP.Controls.Add(this.tabDecrypt);
            this.tabPGP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPGP.Location = new System.Drawing.Point(0, 0);
            this.tabPGP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPGP.Name = "tabPGP";
            this.tabPGP.SelectedIndex = 0;
            this.tabPGP.Size = new System.Drawing.Size(989, 531);
            this.tabPGP.TabIndex = 0;
            this.tabPGP.SelectedIndexChanged += new System.EventHandler(this.tabPGP_SelectedIndexChanged);
            // 
            // tabEncrypt
            // 
            this.tabEncrypt.Controls.Add(this.label1);
            this.tabEncrypt.Controls.Add(this.SendToDropdown);
            this.tabEncrypt.Controls.Add(this.splitContainer1);
            this.tabEncrypt.Location = new System.Drawing.Point(4, 25);
            this.tabEncrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabEncrypt.Name = "tabEncrypt";
            this.tabEncrypt.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabEncrypt.Size = new System.Drawing.Size(981, 502);
            this.tabEncrypt.TabIndex = 0;
            this.tabEncrypt.Text = "Encrypt";
            this.tabEncrypt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recipient:";
            // 
            // SendToDropdown
            // 
            this.SendToDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendToDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SendToDropdown.FormattingEnabled = true;
            this.SendToDropdown.Location = new System.Drawing.Point(84, 2);
            this.SendToDropdown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SendToDropdown.Name = "SendToDropdown";
            this.SendToDropdown.Size = new System.Drawing.Size(889, 24);
            this.SendToDropdown.TabIndex = 1;
            this.SendToDropdown.SelectedIndexChanged += new System.EventHandler(this.SendToDropdown_SelectedIndexChanged);
            // 
            // tabDecrypt
            // 
            this.tabDecrypt.Controls.Add(this.splitContainer2);
            this.tabDecrypt.Location = new System.Drawing.Point(4, 25);
            this.tabDecrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDecrypt.Name = "tabDecrypt";
            this.tabDecrypt.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDecrypt.Size = new System.Drawing.Size(981, 502);
            this.tabDecrypt.TabIndex = 1;
            this.tabDecrypt.Text = "Decrypt";
            this.tabDecrypt.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 4);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer2.Size = new System.Drawing.Size(974, 492);
            this.splitContainer2.SplitterDistance = 301;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 3;
            // 
            // cmdDecrypt
            // 
            this.cmdDecrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdDecrypt.Location = new System.Drawing.Point(0, 0);
            this.cmdDecrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdDecrypt.Name = "cmdDecrypt";
            this.cmdDecrypt.Size = new System.Drawing.Size(70, 301);
            this.cmdDecrypt.TabIndex = 4;
            this.cmdDecrypt.Text = ">>";
            this.cmdDecrypt.UseVisualStyleBackColor = true;
            this.cmdDecrypt.Click += new System.EventHandler(this.cmdDecrypt_Click);
            // 
            // txtInEncrypted
            // 
            this.txtInEncrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInEncrypted.Location = new System.Drawing.Point(0, 0);
            this.txtInEncrypted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInEncrypted.Name = "txtInEncrypted";
            this.txtInEncrypted.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtInEncrypted.Size = new System.Drawing.Size(900, 301);
            this.txtInEncrypted.TabIndex = 0;
            this.txtInEncrypted.Text = "";
            this.txtInEncrypted.TextChanged += new System.EventHandler(this.txtInEncrypted_TextChanged);
            this.txtInEncrypted.Enter += new System.EventHandler(this.txtInEncrypted_Enter);
            // 
            // CopyDecrypted
            // 
            this.CopyDecrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CopyDecrypted.Location = new System.Drawing.Point(0, 0);
            this.CopyDecrypted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CopyDecrypted.Name = "CopyDecrypted";
            this.CopyDecrypted.Size = new System.Drawing.Size(70, 186);
            this.CopyDecrypted.TabIndex = 5;
            this.CopyDecrypted.Text = "Copy";
            this.CopyDecrypted.UseVisualStyleBackColor = true;
            this.CopyDecrypted.Click += new System.EventHandler(this.CopyDecrypted_Click);
            // 
            // txtOutClearText
            // 
            this.txtOutClearText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutClearText.Location = new System.Drawing.Point(0, 0);
            this.txtOutClearText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutClearText.Name = "txtOutClearText";
            this.txtOutClearText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtOutClearText.Size = new System.Drawing.Size(900, 186);
            this.txtOutClearText.TabIndex = 1;
            this.txtOutClearText.Text = "";
            this.txtOutClearText.Enter += new System.EventHandler(this.txtOutClearText_Enter);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.txtInClearText);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.cmdEncrypt);
            this.splitContainer3.Size = new System.Drawing.Size(970, 249);
            this.splitContainer3.SplitterDistance = 899;
            this.splitContainer3.TabIndex = 4;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.txtOutEncrypted);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.CopyEncryptedButton);
            this.splitContainer4.Size = new System.Drawing.Size(970, 208);
            this.splitContainer4.SplitterDistance = 898;
            this.splitContainer4.TabIndex = 6;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.txtInEncrypted);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.cmdDecrypt);
            this.splitContainer5.Size = new System.Drawing.Size(974, 301);
            this.splitContainer5.SplitterDistance = 900;
            this.splitContainer5.TabIndex = 5;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.txtOutClearText);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.CopyDecrypted);
            this.splitContainer6.Size = new System.Drawing.Size(974, 186);
            this.splitContainer6.SplitterDistance = 900;
            this.splitContainer6.TabIndex = 6;
            // 
            // PgpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 531);
            this.Controls.Add(this.tabPGP);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PgpForm";
            this.TabText = "PGP";
            this.Text = "PGP";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPGP.ResumeLayout(false);
            this.tabEncrypt.ResumeLayout(false);
            this.tabEncrypt.PerformLayout();
            this.tabDecrypt.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox txtInClearText;
        private System.Windows.Forms.RichTextBox txtOutEncrypted;
        private System.Windows.Forms.TabControl tabPGP;
        private System.Windows.Forms.TabPage tabEncrypt;
        private System.Windows.Forms.TabPage tabDecrypt;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox txtInEncrypted;
        private System.Windows.Forms.RichTextBox txtOutClearText;
        private System.Windows.Forms.Button cmdDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SendToDropdown;
        private System.Windows.Forms.Button cmdEncrypt;
        private System.Windows.Forms.Button CopyEncryptedButton;
        private System.Windows.Forms.Button CopyDecrypted;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer6;
    }
}
