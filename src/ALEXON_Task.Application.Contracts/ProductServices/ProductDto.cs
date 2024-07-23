using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace ALEXON_Task.ProductServices
{
    public class ProductDto : FullAuditedEntityDto<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
