namespace CookieCookbook.DataAccess;

public interface ISerializable
{
    public string StringsToText(IEnumerable<string> strings);
    public List<string>  TextToStrings(string fileContents);
}