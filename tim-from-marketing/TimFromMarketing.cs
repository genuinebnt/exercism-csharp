using System;
using System.Linq;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var badge = id == null ? name : $"[{id}] - " + name;
        return department == null ? badge + " - OWNER" : badge + $" - {department.ToUpper()}";
    }
}
