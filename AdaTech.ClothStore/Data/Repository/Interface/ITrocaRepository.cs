using AdaTech.ClothStore.Data.Models;

namespace AdaTech.ClothStore.Data.Repository.Interface
{
    public interface ITrocaRepository
    {
        void Add(Venda sale, Troca exchangeSale);
        IEnumerable<Troca> GetAll();
        Troca GetById(int id);
    }
}
