using Recipe.ServicesLibrary.Entities;

namespace Recipe.ServicesLibrary.Repositories;

public class RecipeRepository
{
    public void SaveRecipeToDatabase(RecipeEntity recipeEntity)
    {
        // Save to db
        Console.WriteLine(recipeEntity);
    }
}
