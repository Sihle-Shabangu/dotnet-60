static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(": ", StringSplitOptions.TrimEntries)[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        char[] charsToTrim = { '[', ' ', ']', ':'};
        return logLine.Split(": ", StringSplitOptions.TrimEntries)[0].Trim(charsToTrim).ToLower();
    }

    public static string Reformat(string logLine)
    {
        char[] charsToTrim = { '[', ' ', ']', ':'};
        string message = logLine.Split(": ", StringSplitOptions.TrimEntries)[1].Trim();
        string logLevel = logLine.Split(": ", StringSplitOptions.TrimEntries)[0].Trim(charsToTrim).ToLower();

        return $"{message} ({logLevel})";
    }
}


