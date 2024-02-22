namespace AdaTech.ClothStore.Data.Models
{
    public class Troca
    {
        public static int _id = 1;

        public Troca(DateTime exchangeDate, Venda sale)
        {
            Id = _id++;
            ExchangeDate = exchangeDate;
            Sale = sale;
        }

        public int Id { get; set; }
        public DateTime ExchangeDate { get; set; }
        public Venda Sale { get; set; }
    }
}
