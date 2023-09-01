using System.Text.Json;

namespace CookieCookbook.DataAccess;

public class StringsJsonSerializable : ISerializable
{
    public string StringsToText(IEnumerable<string> strings)
    {
        return JsonSerializer.Serialize(strings);
    }

    public List<string> TextToStrings(string fileContents)
    {
        return JsonSerializer.Deserialize<List<string>>(fileContents) ?? new List<string>();
    }
}