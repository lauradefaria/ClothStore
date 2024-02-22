using AdaTech.ClothStore.Data.Models;
using AdaTech.ClothStore.Data.Repository.Interface;

namespace AdaTech.ClothStore.Data.Repository
{
    public class RetornoRepositoryMemory : IRetornoRepository
    {
        private readonly List<Retorno> _retornos = new List<Retorno>();
        public void Add(Retorno returnSale)
        {
            _retornos.Add(returnSale);
        }

        public IEnumerable<Retorno> GetAll()
        {
            return _retornos;
        }

        public Retorno GetById(int id)
        {
            return _retornos.FirstOrDefault(i => i.Id == id);
        }
    }
}
