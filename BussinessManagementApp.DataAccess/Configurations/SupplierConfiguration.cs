using BussinessManagementApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BussinessManagementApp.DataAccess.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Info).IsRequired();
            builder.Property(x=>x.IsActive).HasDefaultValue(true);
            builder.Property(x=>x.CominicatePersonName).IsRequired();
            builder.Property(x=>x.Email).IsRequired();
            builder.Property(x=>x.TelNo).IsRequired();
        }
    }
}
