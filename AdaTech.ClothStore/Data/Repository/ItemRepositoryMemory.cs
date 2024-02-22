using AdaTech.ClothStore.Data.Exceptions;
using AdaTech.ClothStore.Data.Models;
using AdaTech.ClothStore.Data.Models.Enums;
using AdaTech.ClothStore.Data.Repository.Interface;

namespace AdaTech.ClothStore.Data.Repository
{
    public class ItemRepositoryMemory : IItemRepository
    {
        private readonly List<Item> _items = new List<Item>();

        public ItemRepositoryMemory(List<Item> items)
        {
            _items.Add(new Item("Camiseta", TipoItem.Camiseta, new string[] { "P", "M", "G" }, 39.99m));
            _items.Add(new Item("Calca", TipoItem.Calca, new string[] { "34", "36", "38", "40" }, 109.99m));
            _items.Add(new Item("Sapato", TipoItem.Sapato, new string[] { "36", "37", "38", "39", "40" }, 69.99m));
            _items.Add(new Item("Vestido", TipoItem.Vestido, new string[] { "PP", "P", "M", "G", "GG" }, 99.99m));
        }

        public void Add(Item item)
        {
            _items.Add(item);
        }

        public void Delete(int id)
        {
            Item item = GetById(id);
            _items.Remove(item);
        }

        public IEnumerable<Item> GetAll(string? tamanho, TipoItem? tipo)
        {
            IEnumerable<Item> items = _items;

            if (!string.IsNullOrEmpty(tamanho))
            {
                items = items.Where(i => i.Tamanho.Contains(tamanho.ToUpper()));
            }

            if (tipo.HasValue)
            {
                items = items.Where(i => i.Tipo == tipo);
            }

            return items;
        }

        public Item GetById(int id)
        {
            Item item = _items.FirstOrDefault(i => i.Id == id);
            if (item == null)
                throw new ClothStoreException($"O item com ID {id} não foi encontrado.", 404);
            return item;
        }

        public void Update(Item item)
        {
            var existingItem = _items.FirstOrDefault(i => i.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.Nome = item.Nome;
                existingItem.Preco = item.Preco;
                existingItem.Tipo = item.Tipo;
                existingItem.Tamanho = item.Tamanho;
            }
        }
    }
}
