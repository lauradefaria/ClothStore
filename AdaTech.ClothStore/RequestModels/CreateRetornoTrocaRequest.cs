using System.ComponentModel.DataAnnotations;

namespace AdaTech.ClothStore.RequestModels
{
    public class CreateRetornoTrocaRequest
    {
        [Required]
        public DateTime Date { get; set; }
    }
}
