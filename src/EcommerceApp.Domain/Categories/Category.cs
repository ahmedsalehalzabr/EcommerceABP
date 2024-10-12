using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace EcommerceApp.Categories
{
    public class Category : FullAuditedEntity<int>, IMultiTenant
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }

        public Guid? TenantId { get; set; }

        public Category(string nameAr, string nameEn, string descriptionAr, string descriptionEn) 
        {

            NameAr = nameAr;
            NameEn = nameEn;
            DescriptionAr = descriptionAr;
            DescriptionEn = descriptionEn;
        }
    }
}
