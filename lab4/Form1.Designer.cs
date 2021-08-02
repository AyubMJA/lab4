
namespace lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkTagBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.filestatusLB = new System.Windows.Forms.Label();
            this.htmlTagLB = new System.Windows.Forms.ListBox();
            this.openHTMLFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.processToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1923, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(242, 44);
            this.loadFileToolStripMenuItem.Text = "Load File";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(242, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkTagBTN});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // checkTagBTN
            // 
            this.checkTagBTN.Enabled = false;
            this.checkTagBTN.Name = "checkTagBTN";
            this.checkTagBTN.Size = new System.Drawing.Size(255, 44);
            this.checkTagBTN.Text = "Check Tag";
            this.checkTagBTN.Click += new System.EventHandler(this.checkTagToolStripMenuItem_Click);
            // 
            // filestatusLB
            // 
            this.filestatusLB.AutoSize = true;
            this.filestatusLB.Location = new System.Drawing.Point(848, 61);
            this.filestatusLB.Name = "filestatusLB";
            this.filestatusLB.Size = new System.Drawing.Size(175, 32);
            this.filestatusLB.TabIndex = 1;
            this.filestatusLB.Text = "No File Loaded";
            // 
            // htmlTagLB
            // 
            this.htmlTagLB.FormattingEnabled = true;
            this.htmlTagLB.ItemHeight = 32;
            this.htmlTagLB.Location = new System.Drawing.Point(59, 119);
            this.htmlTagLB.Name = "htmlTagLB";
            this.htmlTagLB.Size = new System.Drawing.Size(1752, 740);
            this.htmlTagLB.TabIndex = 2;
            // 
            // openHTMLFile
            // 
            this.openHTMLFile.FileName = "openHTMLFile";
            this.openHTMLFile.Filter = "html file (*.html)|*.html";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 902);
            this.Controls.Add(this.htmlTagLB);
            this.Controls.Add(this.filestatusLB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkTagBTN;
        private System.Windows.Forms.Label filestatusLB;
        private System.Windows.Forms.ListBox htmlTagLB;
        private System.Windows.Forms.OpenFileDialog openHTMLFile;
    }
}

