using Recipe.ServicesLibrary.Entities;
using Recipe.ServicesLibrary.Repositories;

namespace Recipe.ServicesLibrary.Domains;

public class RecipeDomain
{
    public void SaveRecipe(RecipeEntity recipeEntity)
    {
        // validate model

        var repository = new RecipeRepository();
        repository.SaveRecipeToDatabase(recipeEntity);
    }
}