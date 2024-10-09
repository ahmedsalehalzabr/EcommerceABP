using EcommerceApp.Products;
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
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ConfigureByConvention();

            builder.Property(x => x.NameAr).HasMaxLength(EcommerceAppConsts.GeneralTextMaxlength);
            builder.Property(x => x.NameEn).HasMaxLength(EcommerceAppConsts.GeneralTextMaxlength);
            builder.Property(x => x.DescriptionAr).HasMaxLength(EcommerceAppConsts.DescriptionTextMaxLength);
            builder.Property(x => x.DescriptionAr).HasMaxLength(EcommerceAppConsts.DescriptionTextMaxLength);

            builder.Property(x => x.Price)
              .HasColumnType("decimal(18,2)");

            builder.HasOne(x => x.Category)
                   .WithMany()
                   .HasForeignKey(x => x.CategoryId)
                   .IsRequired();
        }
    }
}
