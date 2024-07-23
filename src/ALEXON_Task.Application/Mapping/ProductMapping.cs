using ALEXON_Task.ProductServices;
using AutoMapper;
using ALEXON_Task.DataEntity;

namespace ALEXON_Task.Mapping
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<CreateUpdateProductDto, Products>();
            CreateMap<Products, ProductDto>();
        }
    }
}
