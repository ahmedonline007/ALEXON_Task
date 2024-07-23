using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace ALEXON_Task.ProductServices
{
    public interface IProductAppServices
    {
        Task<ProductDto> CreateProductAsync(CreateUpdateProductDto product);
        Task<ProductDto> UpdateProductAsync(CreateUpdateProductDto product);
        Task<ProductDto> GetProductAsync(int id);
        Task<bool> DeleteProductAsync(int id);
        Task<PagedResultDto<ProductDto>> GetListAsync();
    }
}
