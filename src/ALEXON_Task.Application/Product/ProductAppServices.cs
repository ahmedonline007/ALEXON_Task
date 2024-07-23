using ALEXON_Task.DataEntity;
using ALEXON_Task.ProductServices;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;
 
namespace ALEXON_Task.Product
{
    public class ProductAppServices : ApplicationService, IProductAppServices
    {
        private readonly IRepository<Products, int> _productsRepository;
        public ProductAppServices(IRepository<Products, int> repository)
        {
            _productsRepository = repository;
        }

        public async Task<ProductDto> CreateProductAsync(CreateUpdateProductDto input)
        {
            var product = ObjectMapper.Map<CreateUpdateProductDto, Products>(input);
            var inserted = await _productsRepository.InsertAsync(product, autoSave: true);
            return ObjectMapper.Map<Products, ProductDto>(inserted);
        }

        public async Task<ProductDto> UpdateProductAsync(CreateUpdateProductDto input)
        {
            var existing = await _productsRepository.GetAsync(input.Id);
            if (existing == null)
            {
                throw new ProductNotFoundException(input.Id);
            }
            var mapped = ObjectMapper.Map<CreateUpdateProductDto, Products>(input, existing);
            var updated = await _productsRepository.UpdateAsync(mapped, autoSave: true);
            return ObjectMapper.Map<Products, ProductDto>(updated);
        }


        public async Task<bool> DeleteProductAsync(int id)
        {
            var existingProduct = await _productsRepository.GetAsync(id);
            if (existingProduct == null)
            {
                return false;
            }

            await _productsRepository.DeleteAsync(existingProduct);
            return true;
        }

        public async Task<PagedResultDto<ProductDto>> GetListAsync()
        { 
            var products = await _productsRepository.WithDetailsAsync(product => product.Category).Result.AsQueryable().ToListAsync();

            var totalCount = await _productsRepository.CountAsync(); 

            return new PagedResultDto<ProductDto>(
                totalCount,
                ObjectMapper.Map<List<Products>, List<ProductDto>>(products)
            );
        }

        public async Task<ProductDto> GetProductAsync(int id)
        {
            var product = await _productsRepository
                           .WithDetailsAsync(x => x.Category)
                           .Result
                           .FirstOrDefaultAsync(x => x.Id == id);

            if (product == null)
            {
                throw new ProductNotFoundException(id);
            }
            return ObjectMapper.Map<Products, ProductDto>(product);
        }


    }
}
