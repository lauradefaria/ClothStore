using AdaTech.ClothStore.Data.Models;

namespace AdaTech.ClothStore.Data.Repository.Interface
{
    public interface IVendaRepository
    {
        void Add(Venda venda);
        Venda GetById(int id);
        IEnumerable<Venda> GetAll();
        void Delete(Venda venda);
    }
}
