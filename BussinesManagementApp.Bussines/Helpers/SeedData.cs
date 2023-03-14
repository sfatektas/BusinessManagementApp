using BussinessManagementApp.DataAccess.Contexts;
using BussinessManagementApp.DataAccess.Interfaces;
using BussinessManagementApp.DataAccess.UnitOfWork;
using BussinessManagementApp.Entities;
using BussinessManagementApp.Entities.IdentityEntities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Helpers
{
    public static class SeedData //TODO Will be adding seed data
    {
        public async static Task EnsurePopulated(IServiceProvider service)
        {
            BussinesManagementDbContext context = service
                .CreateScope().ServiceProvider.GetRequiredService<BussinesManagementDbContext>();

            IdentityDb ıdentitycontext = service
    .CreateScope().ServiceProvider.GetRequiredService<IdentityDb>();

            if (ıdentitycontext.Database.GetPendingMigrations().Any())
            {
                ıdentitycontext.Database.Migrate();
            }
            if (!ıdentitycontext.Users.Any())
            {
                var userManager = service.CreateScope().ServiceProvider.GetRequiredService<UserManager<AppUser>>(); // kullanıcı yok ise yeni kullanıcıları oluşturuyorum.
                var result = await userManager.CreateAsync(new()
                {
                    UserName = "Admin",
                    Email = "Admin@gmail.com",
                    PhoneNumber = "1234567890",
                }, "Admin123");
                result = await userManager.CreateAsync(new()
                {
                    UserName = "Admin2",
                    Email = "Admin2@gmail.com",
                    PhoneNumber = "12345678900",
                }, "Admin123");
                result = await userManager.CreateAsync(new()
                {
                    UserName = "Admin3",
                    Email = "Admin3@gmail.com",
                    PhoneNumber = "123456789000",
                }, "Admin123");
            }

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.MoneyTypes.Any())
            {
                await context.MoneyTypes.AddRangeAsync(
                    new MoneyType()
                    {
                        Name = "TL",
                        IsActive = true,
                        Value = 1
                    },
                    new MoneyType()
                    {
                        Name = "Euro",
                        IsActive = true,
                        Value = 20.19
                    },
                    new MoneyType()
                    {
                        Name = "Dolar",
                        IsActive = true,
                        Value = 18.98
                    });

            }
            if (!context.OrderStatusTypes.Any())
            {
                await context.OrderStatusTypes.AddRangeAsync(
                    new OrderStatusType()
                    {
                        Defination = "Ön Sipariş",
                        IsActive = true,
                    },
                    new OrderStatusType()
                    {
                        Defination = "Tamamlandı",
                        IsActive = true,
                    },
                    new OrderStatusType()
                    {
                        Defination = "İade",
                        IsActive = true,
                    });

            }
            if (!context.CustomerTypes.Any())
            {
                await context.CustomerTypes.AddRangeAsync(
                    new CustomerType()
                    {
                        Defination = "Şahıs",
                        IsActive = true,    
                    },
                    new CustomerType()
                    {
                        Defination = "Tüzel",
                        IsActive = true,
                    });
                    
            }
            await context.SaveChangesAsync();
        }
    }
}
