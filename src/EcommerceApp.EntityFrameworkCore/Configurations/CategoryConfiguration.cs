using EcommerceApp.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace EcommerceApp.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // يعمل ماب للديفولت بريورتي الذي هو جاهز من عنده
            builder.ConfigureByConvention();

            // ادخل الاي دي بيدي 
            // builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.NameAr).HasMaxLength(EcommerceAppConsts.GeneralTextMaxlength);
            builder.Property(x => x.NameEn).HasMaxLength(EcommerceAppConsts.GeneralTextMaxlength);
            builder.Property(x => x.DescriptionAr).HasMaxLength(EcommerceAppConsts.DescriptionTextMaxLength);
            builder.Property(x => x.DescriptionAr).HasMaxLength(EcommerceAppConsts.DescriptionTextMaxLength);

            // الجدول الذي تريد تحفض فيه تسميه كذا 
            builder.ToTable("Categories");
        }
    }
}
