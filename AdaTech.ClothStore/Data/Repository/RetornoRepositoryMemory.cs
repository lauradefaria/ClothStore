using AdaTech.ClothStore.Data.Models;
using AdaTech.ClothStore.Data.Repository.Interface;

namespace AdaTech.ClothStore.Data.Repository
{
    public class RetornoRepositoryMemory : IRetornoRepository
    {
        private readonly List<Retorno> _returns = new List<Retorno>();
        public void Add(Retorno returnSale)
        {
            _returns.Add(returnSale);
        }

        public IEnumerable<Retorno> GetAll()
        {
            return _returns;
        }

        public Retorno GetById(int id)
        {
            return _returns.FirstOrDefault(i => i.Id == id);
        }
    }
}
