using Microsoft.EntityFrameworkCore;
using RecipeBook_ASP.NET.Models;

namespace RecipeBook_ASP.NET.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Receita[]> GetAllReceitasAsync(bool includeIngredientes)
        {
            IQueryable<Receita> query = _context.receitas;

            if (includeIngredientes)
                query = query.Include(pe => pe.ingredientes).ThenInclude(ad => ad.ingrediente);
            query = query.AsNoTracking().OrderBy(c => c.id);

            return await query.ToArrayAsync();
        }

        public async Task<Receita> GetReceitaAsyncById(int receitaId, bool includeIngredientes)
        {
            IQueryable<Receita> query = _context.receitas;

            if (includeIngredientes)
                query = query.Include(pe => pe.ingredientes).ThenInclude(ad => ad.ingrediente);
            query = query.AsNoTracking().OrderBy(aluno => aluno.id).Where(aluno => aluno.id == receitaId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Ingrediente[]> GetAllIngredientesAsync()
        {
            IQueryable<Ingrediente> query = _context.ingredientes;

            query = query.AsNoTracking().OrderBy(c => c.id);

            return await query.ToArrayAsync();
        }

        public async Task<Ingrediente> GetIngredienteAsyncById(int ingredienteId)
        {
            IQueryable<Ingrediente> query = _context.ingredientes;

            query = query.AsNoTracking().OrderBy(aluno => aluno.id).Where(aluno => aluno.id == ingredienteId);

            return await query.FirstOrDefaultAsync();
        }
    }
}