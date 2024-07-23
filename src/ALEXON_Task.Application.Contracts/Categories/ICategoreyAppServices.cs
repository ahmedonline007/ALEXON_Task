using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ALEXON_Task.Categories
{
    public interface ICategoreyAppServices : ICrudAppService
        <CategoryDto,int, PagedAndSortedResultRequestDto, CreateUpdateCategoryDto>
    {
    }
}
