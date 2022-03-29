using RecipeBook_ASP.NET.Models;

namespace RecipeBook_ASP.NET.Data
{
    public interface IRepository
    {
        //Geral
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //Receita
        Task<Receita[]> GetAllReceitasAsync();
        Task<Receita> GetReceitaAsyncById(int receitaId);

        //Ingrediente
        Task<Ingrediente[]> GetAllIngredientesAsync();
        Task<Ingrediente> GetIngredienteAsyncById(int ingredienteId);
        Task<Ingrediente[]> GetAllIngredientesAsyncByReceitaId(int receitaId);
    }
}