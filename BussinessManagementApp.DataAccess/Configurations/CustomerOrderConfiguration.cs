using BussinessManagementApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BussinessManagementApp.DataAccess.Configurations
{
    public class CustomerOrderConfiguration : IEntityTypeConfiguration<CustomerOrder>
    {
        public void Configure(EntityTypeBuilder<CustomerOrder> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.OrderStatusTypeId).IsRequired();
            builder.Property(x => x.ProductId).IsRequired();
            builder.Property(x => x.KdvPrice).IsRequired();
            builder.Property(x => x.CustomerId).IsRequired();
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.Date).IsRequired().HasDefaultValueSql("getdate()");
            builder.Property(x => x.TotalPrice).IsRequired();
            builder.Property(x => x.UnitPrice).IsRequired();
            builder.Property(x => x.OrderStatusTypeId).IsRequired();
            builder.Property(x => x.IsActive).HasDefaultValue(true);
        }
    }
}
