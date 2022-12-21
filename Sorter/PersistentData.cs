namespace Sorter;

public static class PersistentData
{
    private static readonly string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    private static readonly string PersistantDataPath = AppDataPath + @"\Test";
    private static readonly string FoldersToMonitorPath = PersistantDataPath + @"\FoldersToMonitor";
    private static readonly string MainSortingPath = PersistantDataPath + @"\MainSortingFolder";
    private static readonly string SortingOrder = PersistantDataPath + @"\SortingOrder";

    
    public static string SortingPath
    {
        get
        {
            ValidateFolder(PersistantDataPath);
            ValidateFile(MainSortingPath);
            
            return File.ReadAllText(MainSortingPath);
        }
        set
        {
            ValidateFolder(PersistantDataPath);
            ValidateFile(FoldersToMonitorPath);
            
            File.WriteAllText(MainSortingPath, value);
        }
    }


    public static string[] FoldersToMonitor
    {
        get
        {
            ValidateFolder(PersistantDataPath);
            ValidateFile(FoldersToMonitorPath);

            return File.ReadAllLines(FoldersToMonitorPath);
        }
        set
        {
            ValidateFolder(PersistantDataPath);
            ValidateFile(FoldersToMonitorPath);
            
            File.WriteAllLines(FoldersToMonitorPath, value);
        }
    }

    public static string[] SortingOrderList
    {
        get
        {
            ValidateFolder(PersistantDataPath);
            ValidateFile(SortingOrder);

            return File.ReadAllLines(SortingOrder);
        }

        set
        {
            ValidateFolder(PersistantDataPath);
            ValidateFile(SortingOrder);
            
            File.WriteAllLines(SortingOrder, value);
        }
    }

    private static void ValidateFolder(string path) {
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
    }

    private static void ValidateFile(string path) {
        if (!File.Exists(path))
            File.Create(path);
    }
}