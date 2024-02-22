namespace AdaTech.ClothStore.Data.Models
{
    public class ItemVenda
    {
        public ItemVenda(int idProduto, string tamanho, int quantidade, decimal precoItem)
        {
            IdProduto = idProduto;
            Tamanho = tamanho.ToUpper();
            Quantidade = quantidade;
            PrecoItem = precoItem;
        }

        public int IdProduto { get; set; }
        public string Tamanho { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoItem { get; set; }
        public decimal Subtotal => Quantidade * PrecoItem;
    }
}
