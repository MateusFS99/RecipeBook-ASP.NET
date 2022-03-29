using Microsoft.AspNetCore.Mvc;
using RecipeBook_ASP.NET.Data;

namespace RecipeBook_ASP.NET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

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
                var result = await _repo.GetAllReceitasAsync();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("{ReceitaId}")]
        public async Task<IActionResult> GetByReceitaId(int ReceitaId)
        {
            try
            {
                var result = await _repo.GetReceitaAsyncById(ReceitaId);
                
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
    }
}