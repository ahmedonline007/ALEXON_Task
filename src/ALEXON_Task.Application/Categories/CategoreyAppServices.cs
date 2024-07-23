using ALEXON_Task.DataEntity;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ALEXON_Task.Categories
{
    public class CategoreyAppServices : CrudAppService
        <Category, CategoryDto, int, PagedAndSortedResultRequestDto, CreateUpdateCategoryDto>, ICategoreyAppServices
    {
        public CategoreyAppServices(IRepository<Category, int> repository) : base(repository)
        {
        }
    }
}
