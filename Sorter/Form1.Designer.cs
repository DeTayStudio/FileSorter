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
            this.MonitorTab = new System.Windows.Forms.TabPage();
            this.Home = new System.Windows.Forms.TabPage();
            this.RemoveFolderToMonitor = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.MonitorTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderToMonitorList
            // 
            this.FolderToMonitorList.FormattingEnabled = true;
            this.FolderToMonitorList.HorizontalScrollbar = true;
            this.FolderToMonitorList.ItemHeight = 25;
            this.FolderToMonitorList.Location = new System.Drawing.Point(3, 3);
            this.FolderToMonitorList.Name = "FolderToMonitorList";
            this.FolderToMonitorList.Size = new System.Drawing.Size(535, 329);
            this.FolderToMonitorList.TabIndex = 0;
            this.FolderToMonitorList.SelectedIndexChanged += new System.EventHandler(this.FolderToMonitorList_SelectedIndexChanged);
            // 
            // AddFolderToMonitorButton
            // 
            this.AddFolderToMonitorButton.Location = new System.Drawing.Point(547, 6);
            this.AddFolderToMonitorButton.Name = "AddFolderToMonitorButton";
            this.AddFolderToMonitorButton.Size = new System.Drawing.Size(287, 34);
            this.AddFolderToMonitorButton.TabIndex = 1;
            this.AddFolderToMonitorButton.Text = "Add";
            this.AddFolderToMonitorButton.UseVisualStyleBackColor = true;
            this.AddFolderToMonitorButton.Click += new System.EventHandler(this.AddFolderToMonitorButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.MonitorTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 607);
            this.tabControl1.TabIndex = 3;
            // 
            // MonitorTab
            // 
            this.MonitorTab.Controls.Add(this.RemoveFolderToMonitor);
            this.MonitorTab.Controls.Add(this.FolderToMonitorList);
            this.MonitorTab.Controls.Add(this.AddFolderToMonitorButton);
            this.MonitorTab.Location = new System.Drawing.Point(4, 34);
            this.MonitorTab.Name = "MonitorTab";
            this.MonitorTab.Padding = new System.Windows.Forms.Padding(3);
            this.MonitorTab.Size = new System.Drawing.Size(840, 569);
            this.MonitorTab.TabIndex = 0;
            this.MonitorTab.Text = "Monitor";
            this.MonitorTab.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(4, 34);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(840, 569);
            this.Home.TabIndex = 1;
            this.Home.Text = "HomeTab";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // RemoveFolderToMonitor
            // 
            this.RemoveFolderToMonitor.Location = new System.Drawing.Point(568, 55);
            this.RemoveFolderToMonitor.Name = "RemoveFolderToMonitor";
            this.RemoveFolderToMonitor.Size = new System.Drawing.Size(112, 34);
            this.RemoveFolderToMonitor.TabIndex = 2;
            this.RemoveFolderToMonitor.Text = "Remove";
            this.RemoveFolderToMonitor.UseVisualStyleBackColor = true;
            this.RemoveFolderToMonitor.Click += new System.EventHandler(this.RemoveFolderToMonitor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 629);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.MonitorTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox FolderToMonitorList;
        private Button AddFolderToMonitorButton;
        private TabControl tabControl1;
        private TabPage MonitorTab;
        private TabPage Home;
        private Button RemoveFolderToMonitor;
    }
}