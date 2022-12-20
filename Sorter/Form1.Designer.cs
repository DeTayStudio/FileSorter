﻿namespace Sorter
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
            this.RemoveFolderToMonitor = new System.Windows.Forms.Button();
            this.FolderToMonitorGroupBox = new System.Windows.Forms.GroupBox();
            this.SortingGroupBox = new System.Windows.Forms.GroupBox();
            this.SortingOrderAddButton = new System.Windows.Forms.Button();
            this.SortingOrderListBox = new System.Windows.Forms.ListBox();
            this.DragFileToSortLabel = new System.Windows.Forms.Label();
            this.MainFolderTextBox = new System.Windows.Forms.TextBox();
            this.MainSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.MainFolderSelectionButton = new System.Windows.Forms.Button();
            this.SortingOrderRemoveButton = new System.Windows.Forms.Button();
            this.FolderToMonitorGroupBox.SuspendLayout();
            this.SortingGroupBox.SuspendLayout();
            this.MainSettingsGroupBox.SuspendLayout();
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
            this.FolderToMonitorList.Size = new System.Drawing.Size(494, 479);
            this.FolderToMonitorList.TabIndex = 0;
            this.FolderToMonitorList.SelectedIndexChanged += new System.EventHandler(this.FolderToMonitorList_SelectedIndexChanged);
            // 
            // AddFolderToMonitorButton
            // 
            this.AddFolderToMonitorButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddFolderToMonitorButton.Location = new System.Drawing.Point(3, 583);
            this.AddFolderToMonitorButton.Name = "AddFolderToMonitorButton";
            this.AddFolderToMonitorButton.Size = new System.Drawing.Size(494, 63);
            this.AddFolderToMonitorButton.TabIndex = 2;
            this.AddFolderToMonitorButton.Text = "Add";
            this.AddFolderToMonitorButton.UseVisualStyleBackColor = true;
            this.AddFolderToMonitorButton.Click += new System.EventHandler(this.AddFolderToMonitorButton_Click);
            // 
            // RemoveFolderToMonitor
            // 
            this.RemoveFolderToMonitor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RemoveFolderToMonitor.Location = new System.Drawing.Point(3, 646);
            this.RemoveFolderToMonitor.Name = "RemoveFolderToMonitor";
            this.RemoveFolderToMonitor.Size = new System.Drawing.Size(494, 63);
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
            this.FolderToMonitorGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.FolderToMonitorGroupBox.Location = new System.Drawing.Point(500, 73);
            this.FolderToMonitorGroupBox.Name = "FolderToMonitorGroupBox";
            this.FolderToMonitorGroupBox.Size = new System.Drawing.Size(500, 712);
            this.FolderToMonitorGroupBox.TabIndex = 4;
            this.FolderToMonitorGroupBox.TabStop = false;
            this.FolderToMonitorGroupBox.Text = "Monitor";
            this.FolderToMonitorGroupBox.Enter += new System.EventHandler(this.FolderToMonitorGroupBox_Enter);
            // 
            // SortingGroupBox
            // 
            this.SortingGroupBox.Controls.Add(this.SortingOrderRemoveButton);
            this.SortingGroupBox.Controls.Add(this.SortingOrderAddButton);
            this.SortingGroupBox.Controls.Add(this.SortingOrderListBox);
            this.SortingGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SortingGroupBox.Location = new System.Drawing.Point(0, 73);
            this.SortingGroupBox.Name = "SortingGroupBox";
            this.SortingGroupBox.Size = new System.Drawing.Size(500, 712);
            this.SortingGroupBox.TabIndex = 5;
            this.SortingGroupBox.TabStop = false;
            this.SortingGroupBox.Text = "Sorting";
            // 
            // SortingOrderAddButton
            // 
            this.SortingOrderAddButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SortingOrderAddButton.Location = new System.Drawing.Point(3, 646);
            this.SortingOrderAddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortingOrderAddButton.Name = "SortingOrderAddButton";
            this.SortingOrderAddButton.Size = new System.Drawing.Size(494, 63);
            this.SortingOrderAddButton.TabIndex = 1;
            this.SortingOrderAddButton.Text = "Add Sorting Parameter";
            this.SortingOrderAddButton.UseVisualStyleBackColor = true;
            // 
            // SortingOrderListBox
            // 
            this.SortingOrderListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SortingOrderListBox.FormattingEnabled = true;
            this.SortingOrderListBox.ItemHeight = 25;
            this.SortingOrderListBox.Location = new System.Drawing.Point(3, 27);
            this.SortingOrderListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortingOrderListBox.Name = "SortingOrderListBox";
            this.SortingOrderListBox.Size = new System.Drawing.Size(494, 479);
            this.SortingOrderListBox.TabIndex = 0;
            // 
            // DragFileToSortLabel
            // 
            this.DragFileToSortLabel.AllowDrop = true;
            this.DragFileToSortLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DragFileToSortLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DragFileToSortLabel.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DragFileToSortLabel.Location = new System.Drawing.Point(0, 785);
            this.DragFileToSortLabel.Name = "DragFileToSortLabel";
            this.DragFileToSortLabel.Size = new System.Drawing.Size(1444, 157);
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
            this.MainSettingsGroupBox.Size = new System.Drawing.Size(1444, 73);
            this.MainSettingsGroupBox.TabIndex = 7;
            this.MainSettingsGroupBox.TabStop = false;
            this.MainSettingsGroupBox.Text = "Main";
            // 
            // MainFolderSelectionButton
            // 
            this.MainFolderSelectionButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainFolderSelectionButton.Location = new System.Drawing.Point(1228, 27);
            this.MainFolderSelectionButton.Name = "MainFolderSelectionButton";
            this.MainFolderSelectionButton.Size = new System.Drawing.Size(213, 43);
            this.MainFolderSelectionButton.TabIndex = 7;
            this.MainFolderSelectionButton.Text = "...";
            this.MainFolderSelectionButton.UseVisualStyleBackColor = true;
            this.MainFolderSelectionButton.Click += new System.EventHandler(this.MainFolderSelectionButton_Click);
            // 
            // SortingOrderRemoveButton
            // 
            this.SortingOrderRemoveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SortingOrderRemoveButton.Location = new System.Drawing.Point(3, 583);
            this.SortingOrderRemoveButton.Name = "SortingOrderRemoveButton";
            this.SortingOrderRemoveButton.Size = new System.Drawing.Size(494, 63);
            this.SortingOrderRemoveButton.TabIndex = 2;
            this.SortingOrderRemoveButton.Text = "Remove Sorting Parameter";
            this.SortingOrderRemoveButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1444, 942);
            this.Controls.Add(this.FolderToMonitorGroupBox);
            this.Controls.Add(this.SortingGroupBox);
            this.Controls.Add(this.MainSettingsGroupBox);
            this.Controls.Add(this.DragFileToSortLabel);
            this.MaximumSize = new System.Drawing.Size(3838, 2149);
            this.MinimumSize = new System.Drawing.Size(798, 56);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FolderToMonitorGroupBox.ResumeLayout(false);
            this.SortingGroupBox.ResumeLayout(false);
            this.MainSettingsGroupBox.ResumeLayout(false);
            this.MainSettingsGroupBox.PerformLayout();
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
    }
}