namespace AdaTech.ClothStore.Data.Models
{
    public class Troca
    {
        public static int _id = 1;

        public Troca(DateTime dataTroca, Venda vendas)
        {
            Id = _id++;
            DataTroca = dataTroca;
            Vendas = vendas;
        }

        public int Id { get; set; }
        public DateTime DataTroca { get; set; }
        public Venda Vendas { get; set; }
    }
}
