using Volo.Abp.Application.Dtos;

namespace EcommerceApp.Products
{
    public class GetProductListDto : PagedAndSortedResultRequestDto
    {
        public string? Filter { get; set; }
        public int? CategoryId { get; set; }
    }
}
