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
    public class SupplierOrderConfiguration : IEntityTypeConfiguration<SupplierOrder>
    {
        public void Configure(EntityTypeBuilder<SupplierOrder> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Amount).IsRequired();
            builder.Property(x => x.Date).HasDefaultValueSql("getdate()");//alınan siparişin tarihi ekstra eklenmedikçe default olarak şuanki tarih olsun 
            builder.Property(x => x.MoneyTypeId).IsRequired();
            builder.Property(x => x.ProductId).IsRequired();
            builder.Property(x => x.TotalPrice).IsRequired();
            builder.Property(x => x.UnitPrice).IsRequired();
            builder.Property(x => x.IsActive).HasDefaultValue(true);

        }
    }
}
