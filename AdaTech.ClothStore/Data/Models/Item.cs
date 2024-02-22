using AdaTech.ClothStore.Data.Models.Enums;

namespace AdaTech.ClothStore.Data.Models
{
    public class Item
    {
        private static int _id = 1;

        public Item(string name, TipoItem type, string[] sizes, decimal price)
        {
            Id = _id++;
            Name = name;
            Type = type;
            Sizes = sizes.Select(s => s.ToUpper()).ToArray();
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public TipoItem Type { get; set; }
        public string[] Sizes { get; set; }
        public decimal Price { get; set; }
    }
}
