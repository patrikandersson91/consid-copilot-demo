using System.Globalization;

namespace EmptyBlazorApp1.Helpers;

public static class TextHelpers
{
    public static string ToUpper(string text)
    {
        return text.ToUpper();
    }
    public static string ToLower(string text)
    {
        return text.ToLower();
    }
    public static string ToTitleCase(string text)
    {
        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text);
    }

    // truncate
    public static string Truncate(string text, int length)
    {
        if (text.Length <= length)
        {
            return text;
        }
        else
        {
            return text.Substring(0, length) + "...";
        }
    }

    // get a list of random generated full names
    public static List<string> GetRandomNames(int count)
    {
        List<string> names = new();
        for (int i = 0; i < count; i++)
        {
            names.Add(GetRandomName());
        }
        return names;
    }

    // get a random generated full name
    public static string GetRandomName()
    {
        string[] firstNames = { "John", "Jane", "Jack", "Jill", "James", "Judy", "Joe", "Jenny", "Jim", "Janet" };
        string[] lastNames = { "Smith", "Jones", "Williams", "Taylor", "Brown", "Davies", "Evans", "Wilson", "Thomas", "Roberts" };
        Random random = new();
        return $"{firstNames[random.Next(0, firstNames.Length)]} {lastNames[random.Next(0, lastNames.Length)]}";
    }

}
