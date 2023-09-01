namespace CookieCookbook.DataAccess;

public class StringsTextualSerializable : ISerializable
{
    private static readonly string Separator = Environment.NewLine;

    public string StringsToText(IEnumerable<string> strings)
    {
        return string.Join(Separator, strings);
    }

    public List<string> TextToStrings(string fileContents)
    {
        return fileContents.Split(Separator).ToList();
    }
}