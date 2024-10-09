using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace EcommerceApp.Products
{
    public class ProductNotFoundException : BusinessException
    {
        public ProductNotFoundException(int id) : base(EcommerceAppDomainErrorCodes.PRODUCT_NOT_FOUND)
        {
            WithData("id", id);
        }
    }
}
