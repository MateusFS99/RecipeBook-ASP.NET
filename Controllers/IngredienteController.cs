using Microsoft.AspNetCore.Mvc;
using RecipeBook_ASP.NET.Data;

namespace RecipeBook_ASP.NET.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class IngredienteController : ControllerBase
    {
        private readonly IRepository _repo;
        public IngredienteController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllIngredientesAsync();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("{ReceitaId}")]
        public async Task<IActionResult> GetByIngredienteId(int ingredienteId)
        {
            try
            {
                var result = await _repo.GetIngredienteAsyncById(ingredienteId);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
    }
}