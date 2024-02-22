namespace AdaTech.ClothStore.Data.Models
{
    public class Venda
    {
        public static int _id = 1;

        public Venda(DateTime saleDate, string customerName, ItemVenda[] saleItems)
        {
            Id = _id++;
            SaleDate = saleDate;
            CustomerName = customerName;
            SaleItems = saleItems;
        }

        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public string CustomerName { get; set; }
        public ItemVenda[] SaleItems { get; set; }
        public decimal TotalAmount => SaleItems.Sum(item => item.Subtotal);
    }
}
