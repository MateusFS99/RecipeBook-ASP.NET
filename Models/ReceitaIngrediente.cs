namespace RecipeBook_ASP.NET.Models
{
    public class ReceitaIngrediente
    {
        public ReceitaIngrediente() { }

        public ReceitaIngrediente(int receitaId, int ingredienteId)
        {
            this.receitaId = receitaId;
            this.ingredienteId = ingredienteId;
        }

        public int receitaId { get; set; }

        public Receita receita { get; set; }

        public int ingredienteId { get; set; }

        public Ingrediente ingrediente { get; set; }
    }
}