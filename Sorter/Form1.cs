namespace Sorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshAll();

        }

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

        private void ClearListToMonitor_Click(object sender, EventArgs e)
        {
            //Sets an empty string array as the new standard list
            PersistentData.FoldersToMonitor = new string[] {};
            
            //Refreshes the gui part
            RefreshFolderToMonitorList();
        }
        
        private void FolderToMonitorGroupBox_Enter(object sender, EventArgs e)
        {

        }

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

        private void DragFileToSortLabel_Click(object sender, EventArgs e)
        {
            //Opens a FileSelectionDialog
            var explorer = new OpenFileDialog();
            explorer.ShowDialog();
            
            //Sorts the given file
            Sort(explorer.FileName);
        }

        private void Sort(string path)
        {
            if (MainFolderTextBox.Text != String.Empty && Directory.Exists(MainFolderTextBox.Text))
            {
                var fileInfo = new FileInfo(path);

                MessageBox.Show(fileInfo.Name);
            }
            else
            {
                MessageBox.Show(@"Please provide a main sorting folder.");
            }
        }

        #region Refresh

        private void RefreshAll()
        {
            RefreshFolderToMonitorList();
            RefreshMainSortingDirectory();
        }

        private void RefreshFolderToMonitorList()
        {
            //Empties the Folder to monitor list
            FolderToMonitorList.Items.Clear();
            
            //Reads the File again and adds it to the current gui element
            foreach (var item in PersistentData.FoldersToMonitor)
            {
                FolderToMonitorList.Items.Add(item);
            }
        }

        private void RefreshMainSortingDirectory()
        {
            //Empties the current MainFolderTextBox
            MainFolderTextBox.Text = String.Empty;

            //Reads the File again and sets the path as written in the file
            MainFolderTextBox.Text = PersistentData.SortingPath;
        }

        #endregion
    }
}