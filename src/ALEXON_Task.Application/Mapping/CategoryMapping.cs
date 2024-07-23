using ALEXON_Task.Categories;
using ALEXON_Task.DataEntity;
using AutoMapper;

namespace ALEXON_Task.Mapping
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CreateUpdateCategoryDto, Category>();
        }
    }
}
