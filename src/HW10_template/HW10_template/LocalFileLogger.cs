namespace HW10_template;

public class LocalFileLogger<T> : ILogger
{
    private readonly string _pathToFile;
    private readonly Type _type;
    
    public LocalFileLogger(string pathToFile)
    {
        _pathToFile = pathToFile;

        if (!File.Exists(_pathToFile))
        {
            File.Create(_pathToFile).Dispose();
        }
        
        _type = typeof(T);
    }
    
    public void LogInfo(string message) => Log($"[Info]: [{_type}] : {message}");

    public void LogWarning(string message) => Log($"[Warning] : [{_type}] : {message}");

    public void LogError(string message, Exception ex) => Log($"[Error] : [{_type}] : {message}. {ex.Message}");

    private void Log(string message) => File.AppendAllText(_pathToFile, $"{message}\n");
}