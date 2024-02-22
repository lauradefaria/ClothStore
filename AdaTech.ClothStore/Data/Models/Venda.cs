namespace AdaTech.ClothStore.Data.Models
{
    public class Venda
    {
        public static int _id = 1;

        public Venda(DateTime dataVenda, string nomeCliente, ItemVenda[] itemVendido)
        {
            Id = _id++;
            DataVenda = dataVenda;
            NomeCliente = nomeCliente;
            ItemVendido = itemVendido;
        }

        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public string NomeCliente { get; set; }
        public ItemVenda[] ItemVendido { get; set; }
        public decimal Total => ItemVendido.Sum(item => item.Subtotal);
    }
}
