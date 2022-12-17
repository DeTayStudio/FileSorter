namespace Sorter;

public static class PersistentData
{
    public static readonly string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    public static readonly string PersistantDataPath = AppDataPath + @"\Test";
    public static readonly string FoldersToMonitorPath = PersistantDataPath + @"\FoldersToMonitor";

    public static string sortingPath;


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

    private static void ValidateFolder(string path) {
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
    }

    private static void ValidateFile(string path) {
        if (!File.Exists(path))
            File.Create(path);
    }
}