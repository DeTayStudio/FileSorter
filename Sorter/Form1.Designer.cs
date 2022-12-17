namespace Sorter
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
            this.FolderToMonitorList = new System.Windows.Forms.ListBox();
            this.AddFolderToMonitorButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.SortingPath = new System.Windows.Forms.Label();
            this.MonitorTab = new System.Windows.Forms.TabPage();
            this.ClearListToMonitor = new System.Windows.Forms.Button();
            this.RemoveFolderToMonitor = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.MonitorTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderToMonitorList
            // 
            this.FolderToMonitorList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderToMonitorList.FormattingEnabled = true;
            this.FolderToMonitorList.HorizontalScrollbar = true;
            this.FolderToMonitorList.ItemHeight = 25;
            this.FolderToMonitorList.Location = new System.Drawing.Point(3, 6);
            this.FolderToMonitorList.Name = "FolderToMonitorList";
            this.FolderToMonitorList.Size = new System.Drawing.Size(1453, 779);
            this.FolderToMonitorList.TabIndex = 0;
            this.FolderToMonitorList.SelectedIndexChanged += new System.EventHandler(this.FolderToMonitorList_SelectedIndexChanged);
            // 
            // AddFolderToMonitorButton
            // 
            this.AddFolderToMonitorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFolderToMonitorButton.AutoSize = true;
            this.AddFolderToMonitorButton.Location = new System.Drawing.Point(1462, 6);
            this.AddFolderToMonitorButton.Name = "AddFolderToMonitorButton";
            this.AddFolderToMonitorButton.Size = new System.Drawing.Size(271, 71);
            this.AddFolderToMonitorButton.TabIndex = 1;
            this.AddFolderToMonitorButton.Text = "Add";
            this.AddFolderToMonitorButton.UseVisualStyleBackColor = true;
            this.AddFolderToMonitorButton.Click += new System.EventHandler(this.AddFolderToMonitorButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.MonitorTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1747, 870);
            this.tabControl1.TabIndex = 3;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.SortingPath);
            this.Home.Location = new System.Drawing.Point(4, 34);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(840, 569);
            this.Home.TabIndex = 1;
            this.Home.Text = "HomeTab";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // SortingPath
            // 
            this.SortingPath.Location = new System.Drawing.Point(25, 26);
            this.SortingPath.Name = "SortingPath";
            this.SortingPath.Size = new System.Drawing.Size(588, 38);
            this.SortingPath.TabIndex = 0;
            this.SortingPath.Text = "label1";
            this.SortingPath.Click += new System.EventHandler(this.SortingPath_Click);
            // 
            // MonitorTab
            // 
            this.MonitorTab.Controls.Add(this.ClearListToMonitor);
            this.MonitorTab.Controls.Add(this.RemoveFolderToMonitor);
            this.MonitorTab.Controls.Add(this.FolderToMonitorList);
            this.MonitorTab.Controls.Add(this.AddFolderToMonitorButton);
            this.MonitorTab.Location = new System.Drawing.Point(4, 34);
            this.MonitorTab.Name = "MonitorTab";
            this.MonitorTab.Padding = new System.Windows.Forms.Padding(3);
            this.MonitorTab.Size = new System.Drawing.Size(1739, 832);
            this.MonitorTab.TabIndex = 0;
            this.MonitorTab.Text = "Monitor";
            this.MonitorTab.UseVisualStyleBackColor = true;
            // 
            // ClearListToMonitor
            // 
            this.ClearListToMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearListToMonitor.AutoSize = true;
            this.ClearListToMonitor.Location = new System.Drawing.Point(1462, 160);
            this.ClearListToMonitor.Name = "ClearListToMonitor";
            this.ClearListToMonitor.Size = new System.Drawing.Size(271, 66);
            this.ClearListToMonitor.TabIndex = 3;
            this.ClearListToMonitor.Text = "Clear";
            this.ClearListToMonitor.UseVisualStyleBackColor = true;
            this.ClearListToMonitor.Click += new System.EventHandler(this.ClearListToMonitor_Click);
            // 
            // RemoveFolderToMonitor
            // 
            this.RemoveFolderToMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveFolderToMonitor.AutoSize = true;
            this.RemoveFolderToMonitor.Location = new System.Drawing.Point(1462, 83);
            this.RemoveFolderToMonitor.Name = "RemoveFolderToMonitor";
            this.RemoveFolderToMonitor.Size = new System.Drawing.Size(271, 71);
            this.RemoveFolderToMonitor.TabIndex = 2;
            this.RemoveFolderToMonitor.Text = "Remove";
            this.RemoveFolderToMonitor.UseVisualStyleBackColor = true;
            this.RemoveFolderToMonitor.Click += new System.EventHandler(this.RemoveFolderToMonitor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1774, 896);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.MonitorTab.ResumeLayout(false);
            this.MonitorTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox FolderToMonitorList;
        private Button AddFolderToMonitorButton;
        private TabControl tabControl1;
        private TabPage MonitorTab;
        private TabPage Home;
        private Button RemoveFolderToMonitor;
        private Button ClearListToMonitor;
        private Label SortingPath;
    }
}