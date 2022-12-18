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
            this.FolderToMonitorGroupBox = new System.Windows.Forms.GroupBox();
            this.SortingGroupBox = new System.Windows.Forms.GroupBox();
            this.MainFolderTextBox = new System.Windows.Forms.TextBox();
            this.MainSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.MainFolderSelectionButton = new System.Windows.Forms.Button();
            this.FolderToMonitorGroupBox.SuspendLayout();
            this.MainSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderToMonitorList
            // 
            this.FolderToMonitorList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FolderToMonitorList.FormattingEnabled = true;
            this.FolderToMonitorList.HorizontalScrollbar = true;
            this.FolderToMonitorList.ItemHeight = 25;
            this.FolderToMonitorList.Location = new System.Drawing.Point(3, 132);
            this.FolderToMonitorList.Name = "FolderToMonitorList";
            this.FolderToMonitorList.Size = new System.Drawing.Size(494, 929);
            this.FolderToMonitorList.TabIndex = 0;
            this.FolderToMonitorList.SelectedIndexChanged += new System.EventHandler(this.FolderToMonitorList_SelectedIndexChanged);
            // 
            // AddFolderToMonitorButton
            // 
            this.AddFolderToMonitorButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddFolderToMonitorButton.Location = new System.Drawing.Point(3, 1061);
            this.AddFolderToMonitorButton.Name = "AddFolderToMonitorButton";
            this.AddFolderToMonitorButton.Size = new System.Drawing.Size(494, 64);
            this.AddFolderToMonitorButton.TabIndex = 2;
            this.AddFolderToMonitorButton.Text = "Add";
            this.AddFolderToMonitorButton.UseVisualStyleBackColor = true;
            this.AddFolderToMonitorButton.Click += new System.EventHandler(this.AddFolderToMonitorButton_Click);
            // 
            // ClearListToMonitor
            // 
            this.ClearListToMonitor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ClearListToMonitor.Location = new System.Drawing.Point(3, 1189);
            this.ClearListToMonitor.Name = "ClearListToMonitor";
            this.ClearListToMonitor.Size = new System.Drawing.Size(494, 64);
            this.ClearListToMonitor.TabIndex = 1;
            this.ClearListToMonitor.Text = "Clear";
            this.ClearListToMonitor.UseVisualStyleBackColor = true;
            this.ClearListToMonitor.Click += new System.EventHandler(this.ClearListToMonitor_Click);
            // 
            // RemoveFolderToMonitor
            // 
            this.RemoveFolderToMonitor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RemoveFolderToMonitor.Location = new System.Drawing.Point(3, 1125);
            this.RemoveFolderToMonitor.Name = "RemoveFolderToMonitor";
            this.RemoveFolderToMonitor.Size = new System.Drawing.Size(494, 64);
            this.RemoveFolderToMonitor.TabIndex = 3;
            this.RemoveFolderToMonitor.Text = "Remove";
            this.RemoveFolderToMonitor.UseVisualStyleBackColor = true;
            this.RemoveFolderToMonitor.Click += new System.EventHandler(this.RemoveFolderToMonitor_Click);
            // 
            // FolderToMonitorGroupBox
            // 
            this.FolderToMonitorGroupBox.Controls.Add(this.FolderToMonitorList);
            this.FolderToMonitorGroupBox.Controls.Add(this.AddFolderToMonitorButton);
            this.FolderToMonitorGroupBox.Controls.Add(this.RemoveFolderToMonitor);
            this.FolderToMonitorGroupBox.Controls.Add(this.ClearListToMonitor);
            this.FolderToMonitorGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.FolderToMonitorGroupBox.Location = new System.Drawing.Point(0, 74);
            this.FolderToMonitorGroupBox.Name = "FolderToMonitorGroupBox";
            this.FolderToMonitorGroupBox.Size = new System.Drawing.Size(500, 1256);
            this.FolderToMonitorGroupBox.TabIndex = 4;
            this.FolderToMonitorGroupBox.TabStop = false;
            this.FolderToMonitorGroupBox.Text = "Monitor";
            this.FolderToMonitorGroupBox.Enter += new System.EventHandler(this.FolderToMonitorGroupBox_Enter);
            // 
            // SortingGroupBox
            // 
            this.SortingGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SortingGroupBox.Location = new System.Drawing.Point(500, 74);
            this.SortingGroupBox.Name = "SortingGroupBox";
            this.SortingGroupBox.Size = new System.Drawing.Size(500, 1256);
            this.SortingGroupBox.TabIndex = 5;
            this.SortingGroupBox.TabStop = false;
            this.SortingGroupBox.Text = "Sorting";
            // 
            // MainFolderTextBox
            // 
            this.MainFolderTextBox.Location = new System.Drawing.Point(6, 30);
            this.MainFolderTextBox.Name = "MainFolderTextBox";
            this.MainFolderTextBox.Size = new System.Drawing.Size(1897, 31);
            this.MainFolderTextBox.TabIndex = 6;
            this.MainFolderTextBox.TextChanged += new System.EventHandler(this.MainFolderTextBox_TextChanged);
            // 
            // MainSettingsGroupBox
            // 
            this.MainSettingsGroupBox.Controls.Add(this.MainFolderSelectionButton);
            this.MainSettingsGroupBox.Controls.Add(this.MainFolderTextBox);
            this.MainSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainSettingsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.MainSettingsGroupBox.Name = "MainSettingsGroupBox";
            this.MainSettingsGroupBox.Size = new System.Drawing.Size(2093, 74);
            this.MainSettingsGroupBox.TabIndex = 7;
            this.MainSettingsGroupBox.TabStop = false;
            this.MainSettingsGroupBox.Text = "Main";
            // 
            // MainFolderSelectionButton
            // 
            this.MainFolderSelectionButton.Location = new System.Drawing.Point(1909, 30);
            this.MainFolderSelectionButton.Name = "MainFolderSelectionButton";
            this.MainFolderSelectionButton.Size = new System.Drawing.Size(172, 31);
            this.MainFolderSelectionButton.TabIndex = 7;
            this.MainFolderSelectionButton.Text = "...";
            this.MainFolderSelectionButton.UseVisualStyleBackColor = true;
            this.MainFolderSelectionButton.Click += new System.EventHandler(this.MainFolderSelectionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2093, 1330);
            this.Controls.Add(this.SortingGroupBox);
            this.Controls.Add(this.FolderToMonitorGroupBox);
            this.Controls.Add(this.MainSettingsGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FolderToMonitorGroupBox.ResumeLayout(false);
            this.MainSettingsGroupBox.ResumeLayout(false);
            this.MainSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox FolderToMonitorList;
        private Button AddFolderToMonitorButton;
        private Button RemoveFolderToMonitor;
        private Button ClearListToMonitor;
        private GroupBox FolderToMonitorGroupBox;
        private GroupBox SortingGroupBox;
        private TextBox MainFolderTextBox;
        private GroupBox MainSettingsGroupBox;
        private Button MainFolderSelectionButton;
    }
}