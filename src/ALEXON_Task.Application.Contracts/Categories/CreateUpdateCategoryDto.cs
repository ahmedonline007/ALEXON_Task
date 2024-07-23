using Volo.Abp.Application.Dtos;

namespace ALEXON_Task.Categories
{
    public class CreateUpdateCategoryDto : EntityDto<int>
    {
        public string Name { get; set; }
    }
}