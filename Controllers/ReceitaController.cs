using Microsoft.AspNetCore.Mvc;
using RecipeBook_ASP.NET.Data;

namespace RecipeBook_ASP.NET.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ReceitaController : ControllerBase
    {
        private readonly IRepository _repo;

        public ReceitaController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllReceitasAsync(true);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("{ReceitaId}")]
        public async Task<IActionResult> GetByReceitaId(int receitaId)
        {
            try
            {
                var result = await _repo.GetReceitaAsyncById(receitaId, true);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
    }
}