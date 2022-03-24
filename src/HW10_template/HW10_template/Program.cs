using HW10_template;
using HW10_template.TestTypes;
using String = HW10_template.TestTypes.String;

var currentDirectory = Path.Combine(GetCurrentDirectory() ?? throw new DirectoryNotFoundException(), "Files");

var loggerInteger = new LocalFileLogger<Integer>(Path.Combine(currentDirectory, "integer.txt"));

loggerInteger.LogInfo("Info integer");
loggerInteger.LogWarning("Warning integer");
loggerInteger.LogError("Error integer", new Exception("Omg"));

var loggerString = new LocalFileLogger<String>(Path.Combine(currentDirectory, "string.txt"));

loggerString.LogInfo("Info string");
loggerString.LogWarning("Warning string");
loggerString.LogError("Error string", new Exception("Omg2"));

static string? GetCurrentDirectory()
    => Directory.GetParent(Environment.CurrentDirectory)?
        .Parent?
        .Parent?
        .ToString();