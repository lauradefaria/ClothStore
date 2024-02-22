using AdaTech.ClothStore.Data.Exceptions;
using AdaTech.ClothStore.Data.Models;
using AdaTech.ClothStore.Data.Repository.Interface;

namespace AdaTech.ClothStore.Data.Repository
{
    public class VendaRepositoryMemory : IVendaRepository
    {
        private readonly List<Venda> _sales = new List<Venda>();

        public void Add(Venda sale)
        {
            _sales.Add(sale);
        }

        public void Delete(Venda sale)
        {
            _sales.Remove(sale);
        }

        public IEnumerable<Venda> GetAll()
        {
            return _sales;
        }

        public Venda GetById(int id)
        {
            Venda sale = _sales.FirstOrDefault(s => s.Id == id);
            if (sale == null)
                throw new ClothStoreException($"The sale with ID {id} was not found.", 404);

            return sale;
        }
    }
}
