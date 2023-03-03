using BussinessManagementApp.DataAccess.Configurations;
using BussinessManagementApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManagementApp.DataAccess.Contexts
{
    public class BussinesManagementDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SingleCustomer> SingleCustomers { get; set; }
        public DbSet<CorporateCustomer> CorporateCustomers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierOrder> SupplierOrders { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<WarehouseProduct> WarehouseProducts { get; set; }
        public DbSet<MoneyType> MoneyTypes { get; set; }
        public DbSet<OrderStatusType> OrderStatusTypes { get; set; }

        public BussinesManagementDbContext(DbContextOptions<BussinesManagementDbContext> opt) : base(opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new SingleCustomerConfiguration());
            modelBuilder.ApplyConfiguration(new CorporateCustomerConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerOrderConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MoneyTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrderStatusTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierOrderConfiguration());
            modelBuilder.ApplyConfiguration(new WarehouseProductConfiguration());
        }
    }
}
