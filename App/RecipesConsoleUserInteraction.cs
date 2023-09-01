using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.App;

public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{

    private readonly IIngredientsStore _ingredientsStore;

    public RecipesConsoleUserInteraction(IIngredientsStore ingredientsStore)
    {
        _ingredientsStore = ingredientsStore;
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }
    
    public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
    {
        var recipesList = allRecipes.ToList();
        if (!recipesList.Any()) return;
        
        Console.WriteLine("Existing recipes are:" + Environment.NewLine);

        var counter = 1;
        foreach (var recipe in recipesList)
        {
            Console.WriteLine($"*****{counter}*****");
            Console.WriteLine(recipe);
            Console.WriteLine();
            ++counter;
        }
    }

    public void PromptToCreateRecipe()
    {
        Console.WriteLine("Create a new cookie recipe! " +
                          "Available ingredients are:");

        foreach (var ingredient in _ingredientsStore.All)
        {
            Console.WriteLine(ingredient);
        }    
    }

    public IEnumerable<Ingredient> ReadIngredientsFromUser()
    {
        var shallStop = false;
        var ingredients = new List<Ingredient>();

        while (!shallStop)
        {
            Console.WriteLine("Add an ingredient by its ID, " +
                              "or type anything else if finished.");

            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int id))
            {
                var selectedIngredient = _ingredientsStore.GetById(id);
                if (selectedIngredient is not null)
                {
                    ingredients.Add(selectedIngredient);
                }
            }
            else
            {
                shallStop = true;
            }
        }

        return ingredients;
    }
}