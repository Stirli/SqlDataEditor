namespace SqlDataEditor
{
    partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tablesList = new System.Windows.Forms.ListBox();
			this.tablesListContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.selectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new SqlDataEditor.Common.TabControlEx();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.updateTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tablesListContextMenuStrip.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.tabContextMenuStrip.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			this.toolStripContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(627, 487);
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(627, 511);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tablesList);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer1.Size = new System.Drawing.Size(627, 487);
			this.splitContainer1.SplitterDistance = 209;
			this.splitContainer1.TabIndex = 0;
			// 
			// tablesList
			// 
			this.tablesList.ContextMenuStrip = this.tablesListContextMenuStrip;
			this.tablesList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tablesList.FormattingEnabled = true;
			this.tablesList.ItemHeight = 15;
			this.tablesList.Location = new System.Drawing.Point(0, 0);
			this.tablesList.Name = "tablesList";
			this.tablesList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.tablesList.Size = new System.Drawing.Size(209, 487);
			this.tablesList.TabIndex = 0;
			// 
			// tablesListContextMenuStrip
			// 
			this.tablesListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem1});
			this.tablesListContextMenuStrip.Name = "tablesListContextMenuStrip";
			this.tablesListContextMenuStrip.Size = new System.Drawing.Size(106, 26);
			// 
			// selectToolStripMenuItem1
			// 
			this.selectToolStripMenuItem1.Name = "selectToolStripMenuItem1";
			this.selectToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
			this.selectToolStripMenuItem1.Text = "Select";
			this.selectToolStripMenuItem1.Click += new System.EventHandler(this.selectToolStripMenuItem1_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedTab = null;
			this.tabControl1.Size = new System.Drawing.Size(414, 487);
			this.tabControl1.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(627, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// databaseToolStripMenuItem
			// 
			this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
			this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
			this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.databaseToolStripMenuItem.Text = "Database";
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.updateToolStripMenuItem.Text = "Update";
			this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
			// 
			// tabContextMenuStrip
			// 
			this.tabContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateTabToolStripMenuItem});
			this.tabContextMenuStrip.Name = "tabContextMenuStrip";
			this.tabContextMenuStrip.Size = new System.Drawing.Size(181, 48);
			// 
			// updateTabToolStripMenuItem
			// 
			this.updateTabToolStripMenuItem.Name = "updateTabToolStripMenuItem";
			this.updateTabToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.updateTabToolStripMenuItem.Text = "Update";
			this.updateTabToolStripMenuItem.Click += new System.EventHandler(this.updateTabToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 514);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(627, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabel1.Text = "Ready";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(627, 536);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStripContainer1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Form1";
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tablesListContextMenuStrip.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabContextMenuStrip.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private ToolStripContainer toolStripContainer1;
		private SplitContainer splitContainer1;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private MenuStrip menuStrip1;
		private ListBox tablesList;
		private ContextMenuStrip tabContextMenuStrip;
		private ToolStripMenuItem updateTabToolStripMenuItem;
		private ContextMenuStrip tablesListContextMenuStrip;
		private ToolStripMenuItem selectToolStripMenuItem1;
		private ToolStripMenuItem databaseToolStripMenuItem;
		private ToolStripMenuItem updateToolStripMenuItem;
		private Common.TabControlEx tabControl1;
	}
}