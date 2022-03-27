namespace RecipeBook_ASP.NET.Models
{
    public class Ingrediente
    {
        public Ingrediente() { }

        public Ingrediente(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public int id { get; set; }

        public string nome { get; set; }
    }
}