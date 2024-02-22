using AdaTech.ClothStore.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace AdaTech.ClothStore.RequestModels
{
    public class CreateVendaRequest
    {
        [Required]
        public DateTime SaleDate { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public ItemVenda[] SaleItems { get; set; }
    }
}
