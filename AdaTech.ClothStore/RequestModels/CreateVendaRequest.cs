using AdaTech.ClothStore.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace AdaTech.ClothStore.RequestModels
{
    public class CreateVendaRequest
    {
        [Required]
        public DateTime DataVenda { get; set; }
        [Required]
        public string NomeCliente { get; set; }
        [Required]
        public ItemVenda[] ItemVendido { get; set; }
    }
}
