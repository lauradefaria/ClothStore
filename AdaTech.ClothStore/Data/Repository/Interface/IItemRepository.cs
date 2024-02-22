using AdaTech.ClothStore.Data.Models;
using AdaTech.ClothStore.Data.Models.Enums;

namespace AdaTech.ClothStore.Data.Repository.Interface
{
    public interface IItemRepository
    {
        void Add(Item item);
        void Update(Item item);
        void Delete(int id);
        Item GetById(int id);
        IEnumerable<Item> GetAll(string? size, TipoItem? type);
    }
}
