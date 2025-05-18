using Microsoft.AspNetCore.Mvc;
using Recipe.ServicesLibrary.Domains;
using Recipe.ServicesLibrary.Entities;

namespace Recipe.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecipeController : ControllerBase
{
    [HttpPost]
    public IActionResult AddRecipe([FromQuery]RecipeEntity recipeEntity)
    {
        var domain = new RecipeDomain();
        domain.SaveRecipe(recipeEntity);

        return Ok();
    }
}
