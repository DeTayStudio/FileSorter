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
            var explorer = new FolderBrowserDialog();
            explorer.ShowDialog();

            var currentItems = PersistentData.FoldersToMonitor;
            
            var list = currentItems.ToList();
            list.Add(explorer.SelectedPath);
            
            PersistentData.FoldersToMonitor = list.ToArray();
            
            RefreshFolderToMonitorList();
        }
        
        private void RemoveFolderToMonitor_Click(object sender, EventArgs e)
        {
            var currentItems = PersistentData.FoldersToMonitor;
            var index = FolderToMonitorList.SelectedIndex;
            
            if (index >= 0)
            {
                var list = currentItems.ToList();
                list.RemoveAt(index);

                PersistentData.FoldersToMonitor = list.ToArray();
            
                RefreshFolderToMonitorList();
            }
        }

        private void ClearListToMonitor_Click(object sender, EventArgs e)
        {
            PersistentData.FoldersToMonitor = new string[] {};
            RefreshFolderToMonitorList();
        }
        
        private void FolderToMonitorGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void MainFolderSelectionButton_Click(object sender, EventArgs e)
        {
            var explorer = new FolderBrowserDialog();
            explorer.ShowDialog();

            PersistentData.SortingPath = explorer.SelectedPath;
            RefreshMainSortingDirectory();
        }

        private void MainFolderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DragFileToSortLabel_Click(object sender, EventArgs e)
        {
            var explorer = new OpenFileDialog();
            explorer.ShowDialog();
            
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
            FolderToMonitorList.Items.Clear();
            
            foreach (var item in PersistentData.FoldersToMonitor)
            {
                FolderToMonitorList.Items.Add(item);
            }
        }

        private void RefreshMainSortingDirectory()
        {
            MainFolderTextBox.Text = String.Empty;

            MainFolderTextBox.Text = PersistentData.SortingPath;
        }

        #endregion
    }
}