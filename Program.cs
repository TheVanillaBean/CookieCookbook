// See https://aka.ms/new-console-template for more information

using CookieCookbook.App;
using CookieCookbook.DataAccess;
using CookieCookbook.FileAccess;
using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

const FileFormat format = FileFormat.Json;

ISerializable serializable = format == FileFormat.Json ?
    new StringsJsonSerializable() :
    new StringsTextualSerializable();

IStringsRepository stringsRepository = new StringsRepository(serializable);

const string fileName = "recipes";
var fileMetadata = new FileMetadata(fileName, format);

var ingredientsStore = new IngredientsStore();
var recipesRepository = new RecipesRepository(stringsRepository, ingredientsStore);
var recipesUserInteraction = new RecipesConsoleUserInteraction(ingredientsStore);

var app = new CookiesRecipesApp(recipesRepository, recipesUserInteraction);
app.Run(fileMetadata.ToPath());