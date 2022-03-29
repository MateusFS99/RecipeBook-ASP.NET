using RecipeBook_ASP.NET.Models;

namespace RecipeBook_ASP.NET.Data
{
    public class Repository : IRepository
    {
        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<Ingrediente[]> GetAllIngredientesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Ingrediente[]> GetAllIngredientesAsyncByReceitaId(int receitaId)
        {
            throw new NotImplementedException();
        }

        public Task<Receita[]> GetAllReceitasAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Ingrediente> GetIngredienteAsyncById(int ingredienteId)
        {
            throw new NotImplementedException();
        }

        public Task<Receita> GetReceitaAsyncById(int receitaId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}