namespace CookieCookbook.Recipes.Ingredients;

public interface IIngredientsStore
{
    IEnumerable<Ingredient> All { get; }
    Ingredient? GetById(int id);
}