namespace RecipeBook_ASP.NET.Models
{
    public class Receita
    {
        public Receita() { }

        public Receita(int id, string titulo, string instrucoes)
        {
            this.id = id;
            this.titulo = titulo;
            this.instrucoes = instrucoes;
        }

        public int id { get; set; }

        public string titulo { get; set; }

        public string instrucoes { get; set; }
    }
}