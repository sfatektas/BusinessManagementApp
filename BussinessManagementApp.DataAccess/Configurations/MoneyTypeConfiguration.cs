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
    public class MoneyTypeConfiguration : IEntityTypeConfiguration<MoneyType>
    {
        public void Configure(EntityTypeBuilder<MoneyType> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Name).IsRequired();
            builder.Property(x => x.IsActive).HasDefaultValue(true); 
        }
    }
}
