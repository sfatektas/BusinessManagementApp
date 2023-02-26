using BussinessManagementApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManagementApp.DataAccess.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => new { x.SupplierId, x.Name });//Aynı Tedarikçiden aynı ürün isimine sahip 1 den fazla kayıt olamaz. 
            builder.Property(x => x.Origin).IsRequired();
            builder.Property(x => x.SupplierId).IsRequired();
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.UnitPrice).IsRequired();
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
