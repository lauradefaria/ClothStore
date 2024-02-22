using AdaTech.ClothStore.Data.Exceptions;
using AdaTech.ClothStore.Data.Models;
using AdaTech.ClothStore.Data.Repository.Interface;

namespace AdaTech.ClothStore.Data.Repository
{
    public class TrocaRepositoryMemory : ITrocaRepository
    {
        private readonly List<Troca> _troca = new List<Troca>();

        public void Add(Venda sale, Troca trocaMercadoria)
        {
            DateTime dataFinalTroca = sale.DataVenda.AddDays(14);
            if (trocaMercadoria.DataTroca > dataFinalTroca)
                throw new ClothStoreException("Trocas são permitidas até 14 dias úteis.", 500);

            _troca.Add(trocaMercadoria);
        }
        public Troca GetById(int id)
        {
            return _troca.FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<Troca> GetAll()
        {
            return _troca;
        }

    }
}
