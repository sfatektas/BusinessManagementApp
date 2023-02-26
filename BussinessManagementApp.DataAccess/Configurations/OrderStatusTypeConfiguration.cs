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
    public class OrderStatusTypeConfiguration : IEntityTypeConfiguration<OrderStatusType>
    {
        public void Configure(EntityTypeBuilder<OrderStatusType> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.Defination).IsRequired();
        }
    }
}
