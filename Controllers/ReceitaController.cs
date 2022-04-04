using Microsoft.AspNetCore.Mvc;
using RecipeBook_ASP.NET.Data;
using RecipeBook_ASP.NET.Models;

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

        [HttpPost]
        public async Task<IActionResult> Post(Receita receita)
        {
            try
            {
                _repo.Add(receita);
                if (await _repo.SaveChangesAsync())
                    return Ok(receita);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

        [HttpPut("{receitaId}")]
        public async Task<IActionResult> Put(Receita receita, int receitaId)
        {
            try
            {
                bool exists = await _repo.GetReceitaAsyncById(receitaId, false) != null;

                if (!exists)
                    return NotFound();
                _repo.Update(receita);
                if (await _repo.SaveChangesAsync())
                    return Ok(receita);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

        [HttpDelete("{receitaId}")]
        public async Task<IActionResult> Delete(int receitaId)
        {
            try
            {
                var receita = await _repo.GetReceitaAsyncById(receitaId, false);

                if (receita == null)
                    return NotFound();
                _repo.Delete(receita);
                if (await _repo.SaveChangesAsync())
                    return Ok("Deleted!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }
    }
}