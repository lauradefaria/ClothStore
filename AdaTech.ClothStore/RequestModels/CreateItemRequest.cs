using AdaTech.ClothStore.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace AdaTech.ClothStore.RequestsModels
{
    public class CreateItemRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public TipoItem Type { get; set; }
        [Required]
        public string[] Sizes { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}