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
            this.ClearListToMonitor = new System.Windows.Forms.Button();
            this.RemoveFolderToMonitor = new System.Windows.Forms.Button();
            this.FolderToMonitorGroup = new System.Windows.Forms.GroupBox();
            this.FolderToMonitorGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderToMonitorList
            // 
            this.FolderToMonitorList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FolderToMonitorList.FormattingEnabled = true;
            this.FolderToMonitorList.HorizontalScrollbar = true;
            this.FolderToMonitorList.ItemHeight = 25;
            this.FolderToMonitorList.Location = new System.Drawing.Point(3, 31);
            this.FolderToMonitorList.Name = "FolderToMonitorList";
            this.FolderToMonitorList.Size = new System.Drawing.Size(492, 1104);
            this.FolderToMonitorList.TabIndex = 0;
            this.FolderToMonitorList.SelectedIndexChanged += new System.EventHandler(this.FolderToMonitorList_SelectedIndexChanged);
            // 
            // AddFolderToMonitorButton
            // 
            this.AddFolderToMonitorButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddFolderToMonitorButton.Location = new System.Drawing.Point(3, 1135);
            this.AddFolderToMonitorButton.Name = "AddFolderToMonitorButton";
            this.AddFolderToMonitorButton.Size = new System.Drawing.Size(492, 64);
            this.AddFolderToMonitorButton.TabIndex = 2;
            this.AddFolderToMonitorButton.Text = "Add";
            this.AddFolderToMonitorButton.UseVisualStyleBackColor = true;
            this.AddFolderToMonitorButton.Click += new System.EventHandler(this.AddFolderToMonitorButton_Click);
            // 
            // ClearListToMonitor
            // 
            this.ClearListToMonitor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ClearListToMonitor.Location = new System.Drawing.Point(3, 1263);
            this.ClearListToMonitor.Name = "ClearListToMonitor";
            this.ClearListToMonitor.Size = new System.Drawing.Size(492, 64);
            this.ClearListToMonitor.TabIndex = 1;
            this.ClearListToMonitor.Text = "Clear";
            this.ClearListToMonitor.UseVisualStyleBackColor = true;
            this.ClearListToMonitor.Click += new System.EventHandler(this.ClearListToMonitor_Click);
            // 
            // RemoveFolderToMonitor
            // 
            this.RemoveFolderToMonitor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RemoveFolderToMonitor.Location = new System.Drawing.Point(3, 1199);
            this.RemoveFolderToMonitor.Name = "RemoveFolderToMonitor";
            this.RemoveFolderToMonitor.Size = new System.Drawing.Size(492, 64);
            this.RemoveFolderToMonitor.TabIndex = 3;
            this.RemoveFolderToMonitor.Text = "Remove";
            this.RemoveFolderToMonitor.UseVisualStyleBackColor = true;
            this.RemoveFolderToMonitor.Click += new System.EventHandler(this.RemoveFolderToMonitor_Click);
            // 
            // FolderToMonitorGroup
            // 
            this.FolderToMonitorGroup.Controls.Add(this.FolderToMonitorList);
            this.FolderToMonitorGroup.Controls.Add(this.AddFolderToMonitorButton);
            this.FolderToMonitorGroup.Controls.Add(this.RemoveFolderToMonitor);
            this.FolderToMonitorGroup.Controls.Add(this.ClearListToMonitor);
            this.FolderToMonitorGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.FolderToMonitorGroup.Location = new System.Drawing.Point(0, 0);
            this.FolderToMonitorGroup.Name = "FolderToMonitorGroup";
            this.FolderToMonitorGroup.Size = new System.Drawing.Size(498, 1330);
            this.FolderToMonitorGroup.TabIndex = 4;
            this.FolderToMonitorGroup.TabStop = false;
            this.FolderToMonitorGroup.Text = "Monitor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2093, 1330);
            this.Controls.Add(this.FolderToMonitorGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FolderToMonitorGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox FolderToMonitorList;
        private Button AddFolderToMonitorButton;
        private Button RemoveFolderToMonitor;
        private Button ClearListToMonitor;
        private GroupBox FolderToMonitorGroup;
    }
}