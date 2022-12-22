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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FolderToMonitorList = new System.Windows.Forms.ListBox();
            this.AddFolderToMonitorButton = new System.Windows.Forms.Button();
            this.RemoveFolderToMonitor = new System.Windows.Forms.Button();
            this.FolderToMonitorGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SortingGroupBox = new System.Windows.Forms.GroupBox();
            this.SortingOrderEnumComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SortingOrderRemoveButton = new System.Windows.Forms.Button();
            this.SortingOrderAddButton = new System.Windows.Forms.Button();
            this.SortingOrderListBox = new System.Windows.Forms.ListBox();
            this.DragFileToSortLabel = new System.Windows.Forms.Label();
            this.MainFolderTextBox = new System.Windows.Forms.TextBox();
            this.MainSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.MainFolderSelectionButton = new System.Windows.Forms.Button();
            this.systemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.MinimizeToSystemTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.FolderToMonitorGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SortingGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MainSettingsGroupBox.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderToMonitorList
            // 
            this.FolderToMonitorList.Dock = System.Windows.Forms.DockStyle.Top;
            this.FolderToMonitorList.FormattingEnabled = true;
            this.FolderToMonitorList.HorizontalScrollbar = true;
            this.FolderToMonitorList.ItemHeight = 25;
            this.FolderToMonitorList.Location = new System.Drawing.Point(3, 27);
            this.FolderToMonitorList.Name = "FolderToMonitorList";
            this.FolderToMonitorList.Size = new System.Drawing.Size(494, 1554);
            this.FolderToMonitorList.TabIndex = 0;
            this.FolderToMonitorList.SelectedIndexChanged += new System.EventHandler(this.FolderToMonitorList_SelectedIndexChanged);
            // 
            // AddFolderToMonitorButton
            // 
            this.AddFolderToMonitorButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddFolderToMonitorButton.Location = new System.Drawing.Point(0, 0);
            this.AddFolderToMonitorButton.Name = "AddFolderToMonitorButton";
            this.AddFolderToMonitorButton.Size = new System.Drawing.Size(247, 64);
            this.AddFolderToMonitorButton.TabIndex = 2;
            this.AddFolderToMonitorButton.Text = "Add";
            this.AddFolderToMonitorButton.UseVisualStyleBackColor = true;
            this.AddFolderToMonitorButton.Click += new System.EventHandler(this.AddFolderToMonitorButton_Click);
            // 
            // RemoveFolderToMonitor
            // 
            this.RemoveFolderToMonitor.Dock = System.Windows.Forms.DockStyle.Left;
            this.RemoveFolderToMonitor.Location = new System.Drawing.Point(247, 0);
            this.RemoveFolderToMonitor.Name = "RemoveFolderToMonitor";
            this.RemoveFolderToMonitor.Size = new System.Drawing.Size(247, 64);
            this.RemoveFolderToMonitor.TabIndex = 3;
            this.RemoveFolderToMonitor.Text = "Remove";
            this.RemoveFolderToMonitor.UseVisualStyleBackColor = true;
            this.RemoveFolderToMonitor.Click += new System.EventHandler(this.RemoveFolderToMonitor_Click);
            // 
            // FolderToMonitorGroupBox
            // 
            this.FolderToMonitorGroupBox.Controls.Add(this.panel1);
            this.FolderToMonitorGroupBox.Controls.Add(this.FolderToMonitorList);
            this.FolderToMonitorGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.FolderToMonitorGroupBox.Location = new System.Drawing.Point(500, 73);
            this.FolderToMonitorGroupBox.Name = "FolderToMonitorGroupBox";
            this.FolderToMonitorGroupBox.Size = new System.Drawing.Size(500, 764);
            this.FolderToMonitorGroupBox.TabIndex = 4;
            this.FolderToMonitorGroupBox.TabStop = false;
            this.FolderToMonitorGroupBox.Text = "Monitor";
            this.FolderToMonitorGroupBox.Enter += new System.EventHandler(this.FolderToMonitorGroupBox_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RemoveFolderToMonitor);
            this.panel1.Controls.Add(this.AddFolderToMonitorButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 697);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 64);
            this.panel1.TabIndex = 8;
            // 
            // SortingGroupBox
            // 
            this.SortingGroupBox.Controls.Add(this.SortingOrderEnumComboBox);
            this.SortingGroupBox.Controls.Add(this.panel2);
            this.SortingGroupBox.Controls.Add(this.SortingOrderListBox);
            this.SortingGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SortingGroupBox.Location = new System.Drawing.Point(0, 73);
            this.SortingGroupBox.Name = "SortingGroupBox";
            this.SortingGroupBox.Size = new System.Drawing.Size(500, 764);
            this.SortingGroupBox.TabIndex = 5;
            this.SortingGroupBox.TabStop = false;
            this.SortingGroupBox.Text = "Sorting";
            // 
            // SortingOrderEnumComboBox
            // 
            this.SortingOrderEnumComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SortingOrderEnumComboBox.FormattingEnabled = true;
            this.SortingOrderEnumComboBox.Location = new System.Drawing.Point(3, 664);
            this.SortingOrderEnumComboBox.Name = "SortingOrderEnumComboBox";
            this.SortingOrderEnumComboBox.Size = new System.Drawing.Size(494, 33);
            this.SortingOrderEnumComboBox.TabIndex = 8;
            this.SortingOrderEnumComboBox.SelectedIndexChanged += new System.EventHandler(this.SortingOrderEnumComboBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SortingOrderRemoveButton);
            this.panel2.Controls.Add(this.SortingOrderAddButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 697);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 64);
            this.panel2.TabIndex = 8;
            // 
            // SortingOrderRemoveButton
            // 
            this.SortingOrderRemoveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SortingOrderRemoveButton.Location = new System.Drawing.Point(256, 0);
            this.SortingOrderRemoveButton.Name = "SortingOrderRemoveButton";
            this.SortingOrderRemoveButton.Size = new System.Drawing.Size(238, 64);
            this.SortingOrderRemoveButton.TabIndex = 2;
            this.SortingOrderRemoveButton.Text = "Remove Sorting Parameter";
            this.SortingOrderRemoveButton.UseVisualStyleBackColor = true;
            this.SortingOrderRemoveButton.Click += new System.EventHandler(this.SortingOrderRemoveButton_Click);
            // 
            // SortingOrderAddButton
            // 
            this.SortingOrderAddButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SortingOrderAddButton.Location = new System.Drawing.Point(0, 0);
            this.SortingOrderAddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortingOrderAddButton.Name = "SortingOrderAddButton";
            this.SortingOrderAddButton.Size = new System.Drawing.Size(256, 64);
            this.SortingOrderAddButton.TabIndex = 1;
            this.SortingOrderAddButton.Text = "Add Sorting Parameter";
            this.SortingOrderAddButton.UseVisualStyleBackColor = true;
            this.SortingOrderAddButton.Click += new System.EventHandler(this.SortingOrderAddButton_Click);
            // 
            // SortingOrderListBox
            // 
            this.SortingOrderListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SortingOrderListBox.FormattingEnabled = true;
            this.SortingOrderListBox.ItemHeight = 25;
            this.SortingOrderListBox.Location = new System.Drawing.Point(3, 27);
            this.SortingOrderListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortingOrderListBox.Name = "SortingOrderListBox";
            this.SortingOrderListBox.Size = new System.Drawing.Size(494, 1554);
            this.SortingOrderListBox.TabIndex = 0;
            this.SortingOrderListBox.SelectedIndexChanged += new System.EventHandler(this.SortingOrderListBox_SelectedIndexChanged);
            // 
            // DragFileToSortLabel
            // 
            this.DragFileToSortLabel.AllowDrop = true;
            this.DragFileToSortLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DragFileToSortLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DragFileToSortLabel.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DragFileToSortLabel.Location = new System.Drawing.Point(0, 837);
            this.DragFileToSortLabel.Name = "DragFileToSortLabel";
            this.DragFileToSortLabel.Size = new System.Drawing.Size(1508, 157);
            this.DragFileToSortLabel.TabIndex = 0;
            this.DragFileToSortLabel.Text = "Drag file onto here to Sort!";
            this.DragFileToSortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DragFileToSortLabel.Click += new System.EventHandler(this.DragFileToSortLabel_Click);
            // 
            // MainFolderTextBox
            // 
            this.MainFolderTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainFolderTextBox.Location = new System.Drawing.Point(3, 27);
            this.MainFolderTextBox.Multiline = true;
            this.MainFolderTextBox.Name = "MainFolderTextBox";
            this.MainFolderTextBox.Size = new System.Drawing.Size(3120, 43);
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
            this.MainSettingsGroupBox.Size = new System.Drawing.Size(1508, 73);
            this.MainSettingsGroupBox.TabIndex = 7;
            this.MainSettingsGroupBox.TabStop = false;
            this.MainSettingsGroupBox.Text = "Main";
            // 
            // MainFolderSelectionButton
            // 
            this.MainFolderSelectionButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainFolderSelectionButton.Location = new System.Drawing.Point(1292, 27);
            this.MainFolderSelectionButton.Name = "MainFolderSelectionButton";
            this.MainFolderSelectionButton.Size = new System.Drawing.Size(213, 43);
            this.MainFolderSelectionButton.TabIndex = 7;
            this.MainFolderSelectionButton.Text = "...";
            this.MainFolderSelectionButton.UseVisualStyleBackColor = true;
            this.MainFolderSelectionButton.Click += new System.EventHandler(this.MainFolderSelectionButton_Click);
            // 
            // systemTray
            // 
            this.systemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("systemTray.Icon")));
            this.systemTray.Text = "FileSorter";
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.MinimizeToSystemTrayCheckBox);
            this.OptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.OptionsGroupBox.Location = new System.Drawing.Point(1000, 73);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(500, 764);
            this.OptionsGroupBox.TabIndex = 8;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // MinimizeToSystemTrayCheckBox
            // 
            this.MinimizeToSystemTrayCheckBox.AutoSize = true;
            this.MinimizeToSystemTrayCheckBox.Checked = true;
            this.MinimizeToSystemTrayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MinimizeToSystemTrayCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MinimizeToSystemTrayCheckBox.Location = new System.Drawing.Point(3, 27);
            this.MinimizeToSystemTrayCheckBox.Name = "MinimizeToSystemTrayCheckBox";
            this.MinimizeToSystemTrayCheckBox.Size = new System.Drawing.Size(494, 29);
            this.MinimizeToSystemTrayCheckBox.TabIndex = 0;
            this.MinimizeToSystemTrayCheckBox.Text = "Minimize To SystemTray";
            this.MinimizeToSystemTrayCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1508, 994);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.FolderToMonitorGroupBox);
            this.Controls.Add(this.SortingGroupBox);
            this.Controls.Add(this.MainSettingsGroupBox);
            this.Controls.Add(this.DragFileToSortLabel);
            this.MaximumSize = new System.Drawing.Size(3840, 2160);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FolderToMonitorGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.SortingGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.MainSettingsGroupBox.ResumeLayout(false);
            this.MainSettingsGroupBox.PerformLayout();
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox FolderToMonitorList;
        private Button AddFolderToMonitorButton;
        private Button RemoveFolderToMonitor;
        private GroupBox FolderToMonitorGroupBox;
        private GroupBox SortingGroupBox;
        private TextBox MainFolderTextBox;
        private GroupBox MainSettingsGroupBox;
        private Button MainFolderSelectionButton;
        private Label DragFileToSortLabel;
        private Button SortingOrderAddButton;
        private ListBox SortingOrderListBox;
        private Button SortingOrderRemoveButton;
        private Panel panel1;
        private Panel panel2;
        private ComboBox SortingOrderEnumComboBox;
        private NotifyIcon systemTray;
        private GroupBox OptionsGroupBox;
        private CheckBox MinimizeToSystemTrayCheckBox;
    }
}