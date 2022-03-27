using Microsoft.AspNetCore.Mvc;

namespace RecipeBook_ASP.NET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ReceitaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Cuzcuz");
        }
    }
}