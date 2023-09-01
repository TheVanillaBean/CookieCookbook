namespace CookieCookbook.Recipes.Ingredients;

public class Ingredient
{
    public Ingredient(int id, string name, string preparationInstructions)
    {
        Id = id;
        Name = name;
        PreparationInstructions = preparationInstructions;
    }

    public int Id { get; }
    public string Name { get; }
    public string PreparationInstructions { get; }

    public override string ToString() => $"{Id}. {Name}";
    
}