namespace DarkThorne
{
    partial class AdventureViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdventureViewer));
            this.m_infoStrip = new System.Windows.Forms.StatusStrip();
            this.m_mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_splitContainer = new System.Windows.Forms.SplitContainer();
            this.m_outputBox = new AlphaUtils.AlphaRichTextBox();
            this.m_inputBox = new System.Windows.Forms.TextBox();
            this.m_mainMenu.SuspendLayout();
            this.m_splitContainer.Panel1.SuspendLayout();
            this.m_splitContainer.Panel2.SuspendLayout();
            this.m_splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_infoStrip
            // 
            this.m_infoStrip.Location = new System.Drawing.Point(0, 532);
            this.m_infoStrip.Name = "m_infoStrip";
            this.m_infoStrip.Size = new System.Drawing.Size(650, 22);
            this.m_infoStrip.TabIndex = 0;
            this.m_infoStrip.Text = "statusStrip1";
            // 
            // m_mainMenu
            // 
            this.m_mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.m_mainMenu.Location = new System.Drawing.Point(0, 0);
            this.m_mainMenu.Name = "m_mainMenu";
            this.m_mainMenu.Size = new System.Drawing.Size(650, 24);
            this.m_mainMenu.TabIndex = 1;
            this.m_mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem.Text = "E&xit..";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // m_splitContainer
            // 
            this.m_splitContainer.BackColor = System.Drawing.Color.Transparent;
            this.m_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_splitContainer.Location = new System.Drawing.Point(0, 24);
            this.m_splitContainer.Name = "m_splitContainer";
            this.m_splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // m_splitContainer.Panel1
            // 
            this.m_splitContainer.Panel1.Controls.Add(this.m_outputBox);
            this.m_splitContainer.Panel1MinSize = 479;
            // 
            // m_splitContainer.Panel2
            // 
            this.m_splitContainer.Panel2.Controls.Add(this.m_inputBox);
            this.m_splitContainer.Size = new System.Drawing.Size(650, 508);
            this.m_splitContainer.SplitterDistance = 479;
            this.m_splitContainer.TabIndex = 2;
            // 
            // m_outputBox
            // 
            this.m_outputBox.AlphaAmount = 150;
            this.m_outputBox.AlphaBackColor = System.Drawing.Color.Gray;
            this.m_outputBox.BackColor = System.Drawing.Color.Transparent;
            this.m_outputBox.CaretColor = System.Drawing.Color.Gainsboro;
            this.m_outputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_outputBox.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_outputBox.ForeColor = System.Drawing.Color.Beige;
            this.m_outputBox.Location = new System.Drawing.Point(0, 0);
            this.m_outputBox.Name = "m_outputBox";
            this.m_outputBox.ReadOnly = true;
            this.m_outputBox.Size = new System.Drawing.Size(650, 479);
            this.m_outputBox.TabIndex = 0;
            this.m_outputBox.Text = "";
            this.m_outputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_outputBox_KeyDown);
            // 
            // m_inputBox
            // 
            this.m_inputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_inputBox.Location = new System.Drawing.Point(0, 0);
            this.m_inputBox.Name = "m_inputBox";
            this.m_inputBox.Size = new System.Drawing.Size(650, 20);
            this.m_inputBox.TabIndex = 0;
            this.m_inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_inputBox_KeyDown);
            // 
            // AdventureViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DarkThorne.Properties.Resources.funky_thorn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 554);
            this.Controls.Add(this.m_splitContainer);
            this.Controls.Add(this.m_infoStrip);
            this.Controls.Add(this.m_mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.m_mainMenu;
            this.Name = "AdventureViewer";
            this.Text = "DarkThorne Adventure";
            this.Load += new System.EventHandler(this.AdventureViewer_Load);
            this.m_mainMenu.ResumeLayout(false);
            this.m_mainMenu.PerformLayout();
            this.m_splitContainer.Panel1.ResumeLayout(false);
            this.m_splitContainer.Panel2.ResumeLayout(false);
            this.m_splitContainer.Panel2.PerformLayout();
            this.m_splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip m_infoStrip;
        private System.Windows.Forms.MenuStrip m_mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer m_splitContainer;
        private System.Windows.Forms.TextBox m_inputBox;
        private AlphaUtils.AlphaRichTextBox m_outputBox;
    }
}

