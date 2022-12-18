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

        private void RefreshAll()
        {
            RefreshFolderToMonitorList();
        }

        private void RefreshFolderToMonitorList()
        {
            FolderToMonitorList.Items.Clear();
            
            foreach (var item in PersistentData.FoldersToMonitor)
            {
                FolderToMonitorList.Items.Add(item);
            }
        }

        private void SortingPath_Click(object sender, EventArgs e)
        {

        }

        private void FolderToMonitorGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void MainFolderSelectionButton_Click(object sender, EventArgs e)
        {
            var explorer = new FolderBrowserDialog();
            explorer.ShowDialog();

            MainFolderTextBox.Text = explorer.SelectedPath;
        }

        private void MainFolderTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}