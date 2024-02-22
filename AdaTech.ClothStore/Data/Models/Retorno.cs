namespace AdaTech.ClothStore.Data.Models
{
    public class Retorno
    {
        public static int _id = 1;

        public Retorno(DateTime dataRetorno, Venda vendas)
        {
            Id = _id++;
            DataRetorno = dataRetorno;
            Vendas = vendas;
        }

        public int Id { get; set; }
        public DateTime DataRetorno { get; set; }
        public Venda Vendas { get; set; }
    }
}
