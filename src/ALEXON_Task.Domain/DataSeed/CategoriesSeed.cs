using ALEXON_Task.DataEntity;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace ALEXON_Task.DataSeed
{
    public class CategoriesSeed : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Category> _categoryRepository;
        public CategoriesSeed(IRepository<Category, int> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (!await _categoryRepository.AnyAsync())
            {
                var categoryList = new List<Category>()
            {
                new Category(id:1,name:"Category1"),
                new Category(id : 2, name : "Category2"),
                new Category(id : 3, name : "Category3"),
            };

                await _categoryRepository.InsertManyAsync(categoryList);
            }
        }
    }
}