using Microsoft.AspNetCore.Mvc;
using Recipe.ServicesLibrary.Domains;
using Recipe.ServicesLibrary.Entities;

namespace Recipe.Api.Controllers;

[ApiController]
[Route("recipes")]
public class RecipeController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetListAsync(
        [FromQuery] int pageSize,
        [FromQuery] int pageNumber
        )
    {
        return Ok("pageSize=" + pageSize + " " + "&pageNumber=" + pageNumber);
    }
    
    [HttpGet("{recipeId}")]
    public async Task<IActionResult> GetOneAsync([FromRoute]Guid recipeId)
    {
        return Ok("get recipeId=" + recipeId);
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] RecipeEntity recipe)
    {
        return Ok(recipe);
    }
    
    [HttpPut]
    public async Task<IActionResult> UpdateAsync([FromBody] RecipeEntity recipe)
    {
        return Ok(recipe);
    }
    
    [HttpDelete("{recipeId}")]
    public async Task<IActionResult> DeleteAsync([FromRoute]Guid recipeId)
    {
        return Ok();
    }
}
