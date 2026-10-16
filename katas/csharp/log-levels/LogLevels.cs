static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(": ")[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        char[] charsToTrim = { '[', ' ', ']', ':'};
        return logLine.Split(": ")[0].Trim(charsToTrim).ToLower();
    }

    public static string Reformat(string logLine)
    {
        char[] charsToTrim = { '[', ' ', ']', ':'};
        string message = logLine.Split(": ")[1].Trim();
        string logLevel = logLine.Split(": ")[0].Trim(charsToTrim).ToLower();

        return $"{message} ({logLevel})";
    }
}


