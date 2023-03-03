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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Email).IsRequired();
            builder.HasAlternateKey(x => x.Email);//Email ve Telefon numaraları müşteriler için uniq olmalı
            builder.HasAlternateKey(x => x.TelNo);
            builder.Property(x => x.CustomerTypeId).IsRequired();
            builder.Property(x => x.CominicatePersonName).IsRequired();
            builder.Property(x => x.TelNo).IsRequired();
            builder.Property(x => x.IsActive).HasDefaultValue(true);
        }
    }
    public class SingleCustomerConfiguration : IEntityTypeConfiguration<SingleCustomer>
    {
        public void Configure(EntityTypeBuilder<SingleCustomer> builder)
        {
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.CustomerTypeId).IsRequired();
            builder.Property(x => x.CominicatePersonName).IsRequired();
            builder.Property(x => x.TelNo).IsRequired();
        }
    }
    public class CorporateCustomerConfiguration : IEntityTypeConfiguration<CorporateCustomer>
    {
        public void Configure(EntityTypeBuilder<CorporateCustomer> builder)
        { 
            
            builder.Property(x => x.TradeRegisterNumber).IsRequired();
            builder.Property(x => x.CompanyName).IsRequired();
            builder.Property(x => x.TaxNo).IsRequired();

        }
    }
}
