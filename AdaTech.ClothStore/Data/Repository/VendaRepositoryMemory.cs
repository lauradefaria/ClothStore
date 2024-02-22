using AdaTech.ClothStore.Data.Exceptions;
using AdaTech.ClothStore.Data.Models;
using AdaTech.ClothStore.Data.Repository.Interface;

namespace AdaTech.ClothStore.Data.Repository
{
    public class VendaRepositoryMemory : IVendaRepository
    {
        private readonly List<Venda> _vendas = new List<Venda>();

        public void Add(Venda vendas)
        {
            _vendas.Add(vendas);
        }

        public void Delete(Venda vendas)
        {
            _vendas.Remove(vendas);
        }

        public IEnumerable<Venda> GetAll()
        {
            return _vendas;
        }

        public Venda GetById(int id)
        {
            Venda venda = _vendas.FirstOrDefault(s => s.Id == id);
            if (venda == null)
                throw new ClothStoreException($"A venda de ID {id} não foi encontrada.", 404);

            return venda;
        }
    }
}
