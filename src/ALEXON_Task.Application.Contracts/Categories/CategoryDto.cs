using Volo.Abp.Application.Dtos;

namespace ALEXON_Task.Categories
{
    public class CategoryDto : FullAuditedEntityDto<int>
    {
        public string Name { get; set; }
    }
}