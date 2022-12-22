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
            RefreshAll();
        }

        private readonly List<FileSystemWatcher> _watchers = new();

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
            _watchers.Clear();

            //Reads the File again and adds it to the current gui element
            foreach (var folder in PersistentData.FoldersToMonitor)
            {
                FolderToMonitorList.Items.Add(folder);

                var watcher = new FileSystemWatcher(folder);
                watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                                                                | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                watcher.Filter = "*.*";
                watcher.Changed += OnChanged;
                watcher.EnableRaisingEvents = true;
                
                _watchers.Add(watcher);
            }
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            Sort(e.FullPath);
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
            SortingOrderListBox.Items.Clear();

            foreach (var item in PersistentData.SortingOrderList)
            {
                SortingOrderListBox.Items.Add(item);
            }
        }

        #endregion

        #region Sorting

        private void Sort(string path)
        {
            if (MainFolderTextBox.Text != String.Empty && Directory.Exists(MainFolderTextBox.Text))
            {
                var fileInfo = new FileInfo(path);

                var sortPath = PersistentData.SortingPath;
                
                foreach (var sortingOrderParameter in SortingOrderListBox.Items)
                {
                    var sortingOrder = Enum.Parse<SortingOrder>((string)sortingOrderParameter);
                    
                    switch (sortingOrder)
                    {
                        case SortingOrder.DateOfSorting:
                            var dateTime = DateTime.Now;
                            sortPath += @"\" + dateTime.ToShortDateString();
                            break;
                        case SortingOrder.Type:
                            sortPath += @"\" + fileInfo.Extension;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    
                    if (!Directory.Exists(sortPath)) Directory.CreateDirectory(sortPath);
                }

                sortPath += @"\" + fileInfo.Name;

                File.Move(fileInfo.FullName, sortPath);
            }
            else
            {
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
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        
        private void DragFileToSortLabel_DragOver(object? sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data?.GetData(DataFormats.FileDrop)!;
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
    }
}