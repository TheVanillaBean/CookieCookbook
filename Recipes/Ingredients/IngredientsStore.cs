namespace CookieCookbook.Recipes.Ingredients;

public class IngredientsStore : IIngredientsStore
{
    public IEnumerable<Ingredient> All { get; } = new List<Ingredient>
    {
        new(id: 1, name: WheatFlour, preparationInstructions: $"Sieve. {BaseInstructions}"),
        new(id: 2, name: SpeltFlour, preparationInstructions: $"Sieve. {BaseInstructions}"),
        new(id: 3, name: Butter, preparationInstructions: $"Melt on low heat. {BaseInstructions}"),
        new(id: 4, name: Chocolate, preparationInstructions: $"Melt in a water bath. {BaseInstructions}"),
        new(id: 5, name: Sugar, preparationInstructions: $"{BaseInstructions}"),
        new(id: 6, name: Cardamom, preparationInstructions: $"{BaseInstructions}"),
        new(id: 7, name: Cinnamon, preparationInstructions: $"Take half a teaspoon. {BaseInstructions}"),
        new(id: 8, name: CocoaPowder, preparationInstructions: $"{BaseInstructions}"),
    };
    
    public Ingredient? GetById(int id)
    {
        foreach (var ingredient in All)
        {
            if (ingredient.Id == id) return ingredient;
        }

        return null;
    }

    private const string BaseInstructions = "Add to other ingredients.";
    
    public const string WheatFlour = "Wheat flour";
    public const string SpeltFlour = "Spelt flour";
    public const string Butter = "Butter";
    public const string Chocolate = "Chocolate";
    public const string Sugar = "Sugar";
    public const string Cardamom = "Cardamomr";
    public const string Cinnamon = "Cinnamon";
    public const string CocoaPowder = "Cocoa Powder";
}