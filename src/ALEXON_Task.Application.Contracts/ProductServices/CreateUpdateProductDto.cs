using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace ALEXON_Task.ProductServices
{
    public class CreateUpdateProductDto : EntityDto<int>
    {
        [Required(ErrorMessage = "Name is Required.")]
        [StringLength(500, ErrorMessage = "Name cannot be longer than 500 characters.")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
