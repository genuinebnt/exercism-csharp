using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

static class LogLine
{
    private static readonly Regex Rx = new Regex(@"[(\w*?)]:(.*)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
    
    private static IEnumerable<string> GetGroups(string logLine)
    {
        return Rx.Matches(logLine).Select(match => match.Groups).Select((group, i) => group[i].Value.Trim());
    }
    
    public static string Message(string logLine)
    {
        return GetGroups(logLine).First();
    }

    public static string LogLevel(string logLine)
    {
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }

    public static string Reformat(string logLine)
    {
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
