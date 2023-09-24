namespace PGP
{
    partial class EditorForm
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
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEditor
            // 
            this.txtEditor.AcceptsReturn = true;
            this.txtEditor.AcceptsTab = true;
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Location = new System.Drawing.Point(0, 0);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEditor.Size = new System.Drawing.Size(800, 450);
            this.txtEditor.TabIndex = 0;
            this.txtEditor.WordWrap = false;
            this.txtEditor.TextChanged += new System.EventHandler(this.txtEditor_TextChanged);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEditor);
            this.Name = "EditorForm";
            this.TabText = "Editor";
            this.Text = "Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditorForm_FormClosing);
            this.Load += new System.EventHandler(this.Editor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEditor;
    }
}