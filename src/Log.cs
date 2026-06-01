namespace ModUploader;

public static class Log
{
    private static StreamWriter streamWriter;

    static Log()
    {
        FileStream fileStream = new FileStream("mod-uploader.log", FileMode.OpenOrCreate);
        streamWriter = new StreamWriter(fileStream);
    }

    public static void Info(string log)
    {
        Console.WriteLine(log);
        streamWriter.WriteLine(log);
    }
    
    public static void Warn(string log)
    {
        Console.WriteLine($"\x1b[33m{log}\x1b[0m");
        streamWriter.WriteLine(log);
    }
    
    public static void Error(string log)
    {
        Console.WriteLine($"\x1b[31m{log}\x1b[0m");
        streamWriter.WriteLine(log);
    }
}