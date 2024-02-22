using AdaTech.ClothStore.Data.Exceptions;
using AdaTech.ClothStore.Data.Models;
using AdaTech.ClothStore.Data.Repository.Interface;

namespace AdaTech.ClothStore.Data.Repository
{
    public class TrocaRepositoryMemory : ITrocaRepository
    {
        private readonly List<Troca> _exchange = new List<Troca>();

        public void Add(Venda sale, Troca exchangeSale)
        {
            DateTime finalExchangeDate = sale.SaleDate.AddDays(7);
            if (exchangeSale.ExchangeDate > finalExchangeDate)
                throw new ClothStoreException("Exchanges are allowed only within 7 business days after the sale date.", 500);

            _exchange.Add(exchangeSale);
        }

        public IEnumerable<Troca> GetAll()
        {
            return _exchange;
        }

        public Troca GetById(int id)
        {
            return _exchange.FirstOrDefault(i => i.Id == id);
        }
    }
}
