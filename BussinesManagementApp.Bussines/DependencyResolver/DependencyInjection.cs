using BussinessManagementApp.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using BussinessManagementApp.Entities.IdentityEntities;
using BussinesManagementApp.Bussines.Services;

namespace BussinesManagementApp.Bussines.DependencyResolver
{
    public static class DependencyInjection
    {
        public static void DependencyExtension(this IServiceCollection services)
        {
            services.AddDbContext<BussinesManagementDbContext>(x => x.UseSqlServer("server=.;Database=BussinesManagementDb; integrated security=true;")); //TODO appconfig 

            //sanal server ile bahsedilen kavramın detylandırılmasını iste !

            services.AddDbContext<IdentityDb>(x => x.UseSqlServer("server=.;Database=IdentityDb; integrated security=true;"));
            services.AddIdentity<AppUser, AppRole>(opt =>
            {
                //password Options
                opt.Password.RequiredLength = 6;
                opt.Password.RequireDigit = true;
                opt.Password.RequireNonAlphanumeric= false;
                //Lockout Options
                opt.Lockout.MaxFailedAccessAttempts = 5;
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3);
                opt.Lockout.AllowedForNewUsers = true;

                //Sıgin Options
                opt.SignIn.RequireConfirmedPhoneNumber = false;
            }).AddEntityFrameworkStores<IdentityDb>();

            services.AddScoped<IdentityService>();
        }
    }
}
