using Microsoft.AspNetCore.Mvc;
using RecipeBook_ASP.NET.Data;

namespace RecipeBook_ASP.NET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class IngredienteController : ControllerBase
    {
        public IngredienteController(IRepository repo)
        {

        }
    }
}