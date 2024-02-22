using AdaTech.ClothStore.Data.Models;

namespace AdaTech.ClothStore.Data.Repository.Interface
{
    public interface IRetornoRepository
    {
        void Add(Retorno retorno);
        IEnumerable<Retorno> GetAll();
        Retorno GetById(int id);
    }
}
