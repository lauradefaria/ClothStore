using System.ComponentModel.DataAnnotations;

namespace AdaTech.ClothStore.RequestModels
{
    public class CreateRetornoTrocaRequest
    {
        [Required]
        public DateTime Data { get; set; }
    }
}
