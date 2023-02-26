using BussinessManagementApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManagementApp.DataAccess.Configurations
{
    public class WarehouseProductConfiguration : IEntityTypeConfiguration<WarehouseProduct>
    {
        public void Configure(EntityTypeBuilder<WarehouseProduct> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.ProductId); //Depoda aynı çeşit ürün sadece bir kere bulunabilir stokta olup olmamasına göre IsActive değeri 0,1 
            //olarak değiştirilebilir.
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x=>x.IsActive).HasDefaultValue(true);
   /*         builder.HasOne(x => x.Product).WithOne(x => x.WarehouseProduct).HasForeignKey("P");*///olası hata
        }
    }
}
