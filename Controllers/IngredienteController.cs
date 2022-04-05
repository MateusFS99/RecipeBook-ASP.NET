using Microsoft.AspNetCore.Mvc;
using RecipeBook_ASP.NET.Data;
using RecipeBook_ASP.NET.Models;

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

        [HttpPost]
        public async Task<IActionResult> Post(Ingrediente ingrediente)
        {
            try
            {
                _repo.Add(ingrediente);
                if (await _repo.SaveChangesAsync())
                    return Ok(ingrediente);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

        [HttpPut("{ingredienteId}")]
        public async Task<IActionResult> Put(Ingrediente ingrediente, int ingredienteId)
        {
            try
            {
                bool exists = await _repo.GetIngredienteAsyncById(ingredienteId) != null;

                if (!exists)
                    return NotFound();
                _repo.Update(ingrediente);
                if (await _repo.SaveChangesAsync())
                    return Ok(ingrediente);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

        [HttpDelete("{ingredienteId}")]
        public async Task<IActionResult> Delete(int ingredienteId)
        {
            try
            {
                var ingrediente = await _repo.GetIngredienteAsyncById(ingredienteId);

                if (ingrediente == null)
                    return NotFound();
                _repo.Delete(ingrediente);
                if (await _repo.SaveChangesAsync())
                    return Ok(new {message = "Deleted!"});
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }
    }
}