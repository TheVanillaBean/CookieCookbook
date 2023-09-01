namespace CookieCookbook.DataAccess;

public interface IStringsRepository
{
    List<string> Read(string filePath);
    void Write(string filePath, IEnumerable<string> strings);
}