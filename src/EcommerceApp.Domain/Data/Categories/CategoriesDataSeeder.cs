using EcommerceApp.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace EcommerceApp.Data.Categories
{
    public class CategoriesDataSeeder : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Category, int> categoryRepository;

        public CategoriesDataSeeder(IRepository<Category, int> categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (!await categoryRepository.AnyAsync())
            {
                var categories = new List<Category>
            {
                new Category(
                     nameAr:"اطعمة ومشروبات",
                     nameEn:"Food & Drinks",
                     descriptionAr:"جميع انواع الاطعمة والماكولات",
                     descriptionEn:"All food and drink categories"),
                new Category(
                     nameAr:"مواد منظفة",
                     nameEn:"Detergents",
                     descriptionAr:"المنظفات بانواعها",
                     descriptionEn:"All matrials used for ckeaniing"),
                new Category(
                     nameAr:"بلاستيك",
                     nameEn:"Plastic",
                     descriptionAr:"البلاستيك القابل للتدوير والغير القابل للتدوير",
                     descriptionEn:"All reusable and non-reusable plastic materials"),

            };

                await this.categoryRepository.InsertManyAsync(categories);
            }

        }
    }
}
