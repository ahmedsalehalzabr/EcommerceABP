using AutoMapper;
using EcommerceApp.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Mappings
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<CreateUpdateProductDto, Product>();
            CreateMap<Product, ProductDto>();
        }
    }
}