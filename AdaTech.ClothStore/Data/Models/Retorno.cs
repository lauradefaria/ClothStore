namespace AdaTech.ClothStore.Data.Models
{
    public class Retorno
    {
        public static int _id = 1;

        public Retorno(DateTime returnDate, Venda sale)
        {
            Id = _id++;
            ReturnDate = returnDate;
            Sale = sale;
        }

        public int Id { get; set; }
        public DateTime ReturnDate { get; set; }
        public Venda Sale { get; set; }
    }
}
