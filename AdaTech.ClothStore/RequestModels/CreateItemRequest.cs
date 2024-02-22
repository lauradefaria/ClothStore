using AdaTech.ClothStore.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace AdaTech.ClothStore.RequestsModels
{
    public class CreateItemRequest
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public TipoItem Tipo { get; set; }
        [Required]
        public string[] Tamanho { get; set; }
        [Required]
        public decimal Preco { get; set; }
    }
}