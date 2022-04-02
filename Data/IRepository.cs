using RecipeBook_ASP.NET.Models;

namespace RecipeBook_ASP.NET.Data
{
    public interface IRepository
    {
        //Desenvolvido os Repositórios das entidades juntos por se tratar de apenas 2 entidades

        //Geral
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //Receita
        Task<Receita[]> GetAllReceitasAsync(bool includeIngredientes);
        Task<Receita> GetReceitaAsyncById(int receitaId, bool includeIngredientes);

        //Ingrediente
        Task<Ingrediente[]> GetAllIngredientesAsync();
        Task<Ingrediente> GetIngredienteAsyncById(int ingredienteId);
    }
}