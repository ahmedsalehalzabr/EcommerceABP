using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace EcommerceApp.Products
{
    public interface IProductsAppService
    {
        Task<ProductDto> CreateProductAsync(CreateUpdateProductDto input);
        Task<ProductDto> UpdateProductAsync(CreateUpdateProductDto input);
        Task<ProductDto> GetProductAsync(int id);
        Task<bool> DeleteProductAsync(int id);
        Task<PagedResultDto<ProductDto>> GetListAsync(GetProductListDto input);
    }
}
