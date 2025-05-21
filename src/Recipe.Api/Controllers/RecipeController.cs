using Microsoft.AspNetCore.Mvc;
using Recipe.ServicesLibrary.Domains;
using Recipe.ServicesLibrary.Entities;

namespace Recipe.Api.Controllers;

[ApiController]
[Route("recipes")]
public class RecipeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
