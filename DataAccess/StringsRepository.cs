namespace CookieCookbook.DataAccess;

public class StringsRepository : IStringsRepository
{
    private readonly ISerializable _serializable;

    public StringsRepository(ISerializable serializable)
    {
        _serializable = serializable;
    }

    public List<string> Read(string filePath)
    {
        if (!File.Exists(filePath)) return new List<string>();
        var fileContents = File.ReadAllText(filePath);
        return _serializable.TextToStrings(fileContents);
    }
    
    public void Write(string filePath, IEnumerable<string> strings)
    {
        File.WriteAllText(filePath, _serializable.StringsToText(strings));
    }
}