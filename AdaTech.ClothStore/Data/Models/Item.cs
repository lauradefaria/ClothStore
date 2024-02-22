using AdaTech.ClothStore.Data.Models.Enums;

namespace AdaTech.ClothStore.Data.Models
{
    public class Item
    {
        private static int _id = 1;

        public Item(string nome, TipoItem tipo, string[] tamanho, decimal preco)
        {
            Id = _id++;
            Nome = nome;
            Tipo = tipo;
            Tamanho = tamanho.Select(s => s.ToUpper()).ToArray();
            Preco = preco;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public TipoItem Tipo { get; set; }
        public string[] Tamanho { get; set; }
        public decimal Preco { get; set; }
    }
}
