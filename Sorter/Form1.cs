namespace Sorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SortingOrderEnumComboBox.DataSource = Enum.GetValues(typeof(SortingOrder));
            DragFileToSortLabel.DragEnter += DragFileToSortLabel_DragEnter;
            DragFileToSortLabel.DragDrop += (DragFileToSortLabel_DragOver);
            Resize += From1_Resize;
            systemTray.DoubleClick += SystemTrayDoubleClick;
            RefreshAll();
        }
        
        private readonly List<FileSystemWatcher> _watchers = new();
        
        private void From1_Resize(object? sender, EventArgs e)
        {
            if (MinimizeToSystemTrayCheckBox.Checked)
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    Hide();
                    systemTray.Visible = true;
                }
            }
        }
        
        private void SystemTrayDoubleClick(object? sender, EventArgs e)
        {
            if (MinimizeToSystemTrayCheckBox.Checked)
            {
                Show();
                WindowState = FormWindowState.Normal;
                systemTray.Visible = false;
            }
        }

        #region Monitor

        private void FolderToMonitorList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddFolderToMonitorButton_Click(object sender, EventArgs e)
        {
            //Opens a folder selection dialog
            var explorer = new FolderBrowserDialog();
            explorer.ShowDialog();

            //Gets the current list of folders which are being monitored
            var currentItems = PersistentData.FoldersToMonitor;
            var list = currentItems.ToList();
            
            //Adds the newly selected directory to the current list
            list.Add(explorer.SelectedPath);
            
            //Sets the updated list as the new standard list
            PersistentData.FoldersToMonitor = list.ToArray();
            
            //Refreshes the visual gui part
            RefreshFolderToMonitorList();
        }
        
        private void RemoveFolderToMonitor_Click(object sender, EventArgs e)
        {
            //Gets the current list of Folders which are being monitored
            var currentItems = PersistentData.FoldersToMonitor;
            
            //Gets the index of the element which should be removed
            var index = FolderToMonitorList.SelectedIndex;
            
            if (index >= 0)
            {
                //Converts array to list
                var list = currentItems.ToList();
                
                //Removes the desired index from the list
                list.RemoveAt(index);

                //Sets the updated list as the new standard list
                PersistentData.FoldersToMonitor = list.ToArray();
            
                //Refreshes the gui part
                RefreshFolderToMonitorList();
            }
        }
        
        private void FolderToMonitorGroupBox_Enter(object sender, EventArgs e)
        {

        }

        #endregion

        #region MainFolder

        private void MainFolderSelectionButton_Click(object sender, EventArgs e)
        {
            //Opens a folder selection dialog
            var explorer = new FolderBrowserDialog();
            explorer.ShowDialog();

            //Sets the new sortingPath as the selected path
            PersistentData.SortingPath = explorer.SelectedPath;
            
            //Refreshes the gui part
            RefreshMainSortingDirectory();
        }

        private void MainFolderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion
        
        #region Refresh

        private void RefreshAll()
        {
            RefreshFolderToMonitorList();
            RefreshMainSortingDirectory();
            RefreshSortingOrderList();
        }

        private void RefreshFolderToMonitorList()
        {
            //Empties the Folder to monitor list
            FolderToMonitorList.Items.Clear();
            
            //Empties watchers list
            foreach(var watcher in _watchers) watcher.Dispose();
            _watchers.Clear();

            //Reads the File again and adds it to the current gui element
            foreach (var folder in PersistentData.FoldersToMonitor)
            {
                //Adds folders to monitorList
                FolderToMonitorList.Items.Add(folder);

                //Creates a watcher for each folder
                var watcher = new FileSystemWatcher(folder);
                watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                                                                | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                watcher.Filter = "*.*";
                watcher.Changed += ((_, args) => Sort(args.FullPath)) ;
                watcher.EnableRaisingEvents = true;
                
                //Adds the watcher to the watcherList
                _watchers.Add(watcher);
            }
        }
        
        private void RefreshMainSortingDirectory()
        {
            //Empties the current MainFolderTextBox
            MainFolderTextBox.Text = String.Empty;

            //Reads the File again and sets the path as written in the file
            MainFolderTextBox.Text = PersistentData.SortingPath;
        }

        private void RefreshSortingOrderList()
        {
            //Empties the current sortingOrderListBox
            SortingOrderListBox.Items.Clear();

            //Reads the File again and adds it to the current gui element
            foreach (var item in PersistentData.SortingOrderList)
            {
                SortingOrderListBox.Items.Add(item);
            }
        }

        #endregion

        #region Sorting

        private void Sort(string path)
        {
            //Checks if a main folder is selected
            if (MainFolderTextBox.Text != String.Empty && Directory.Exists(MainFolderTextBox.Text))
            {
                //Gets the fileInfo of the file which should be sorted
                var fileInfo = new FileInfo(path);

                //sets the destination path where the file should be moved to
                var destPath = PersistentData.SortingPath;
                
                //Loops through all active sortingOrderParameters
                foreach (var sortingOrderParameter in SortingOrderListBox.Items)
                {
                    //Parses the string from the sortingOrderList to a usable enum
                    var sortingOrder = Enum.Parse<SortingOrder>((string)sortingOrderParameter);
                    
                    switch (sortingOrder)
                    {
                        case SortingOrder.DateOfSorting:
                            destPath += @"\" + DateTime.Now.ToShortDateString();
                            break;
                        case SortingOrder.FileType:
                            destPath += @"\" + fileInfo.Extension;
                            break;
                        case SortingOrder.FileCreationDate:
                            destPath += @"\" + fileInfo.CreationTime.ToShortDateString();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    
                    //Checks if the current destinationPath exists, and otherwise creates it
                    if (!Directory.Exists(destPath)) Directory.CreateDirectory(destPath);
                }

                //Completes the destinationPath by adding the fileName at the end
                destPath += @"\" + fileInfo.Name;

                //Moves the File from current Path to the generated destinationPath
                File.Move(fileInfo.FullName, destPath);
            }
            else
            {
                //Sends MessageBox if no main folder is selected
                MessageBox.Show(@"Please provide a main sorting folder.");
            }
        }
        
        private void DragFileToSortLabel_Click(object sender, EventArgs e)
        {
            //Opens a FileSelectionDialog
            var explorer = new OpenFileDialog();
            explorer.ShowDialog();
            
            //Sorts the given file
            Sort(explorer.FileName);
        }
        
        private void DragFileToSortLabel_DragEnter(object? sender, DragEventArgs e)
        {
            //Changes the cursor if file is DragDrop
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        
        private void DragFileToSortLabel_DragOver(object? sender, DragEventArgs e)
        {
            //Gets the files paths which are dropped on the label
            string[] files = (string[])e.Data?.GetData(DataFormats.FileDrop)!;
            
            //Sorts each file
            foreach (string file in files) Sort(file);
        }
        
        private void SortingOrderAddButton_Click(object sender, EventArgs e)
        {
            var sortingOrder = (SortingOrder) SortingOrderEnumComboBox.SelectedItem;
            
            //Gets the current list of folders which are being monitored
            var currentItems = PersistentData.SortingOrderList;
            var list = currentItems.ToList();
            
            //Adds the newly selected directory to the current list
            list.Add(sortingOrder.ToString());
            
            //Sets the updated list as the new standard list
            PersistentData.SortingOrderList = list.ToArray();
            
            //Refreshes the visual gui part
            RefreshSortingOrderList();
        }
        
        private void SortingOrderRemoveButton_Click(object sender, EventArgs e)
        {
            //Gets the current list of Folders which are being monitored
            var currentItems = PersistentData.SortingOrderList;
            
            //Gets the index of the element which should be removed
            var index = SortingOrderListBox.SelectedIndex;
            
            if (index >= 0)
            {
                //Converts array to list
                var list = currentItems.ToList();
                
                //Removes the desired index from the list
                list.RemoveAt(index);

                //Sets the updated list as the new standard list
                PersistentData.SortingOrderList = list.ToArray();
            
                //Refreshes the gui part
                RefreshSortingOrderList();
            }
        }

        private void SortingOrderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void SortingOrderEnumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Options
        
        

        #endregion
    }
}