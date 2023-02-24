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

namespace BussinesManagementApp.Bussines.DependencyResolver
{
    public static class DependencyInjection
    {
        public static void DependencyExtension(this IServiceCollection services)
        {
            services.AddDbContext<BussinesManagementDb>(x => x.UseSqlServer("server=.;Database=BussinesManagementDb; integrated security=true;")); //TODO appconfig 

            //services.AddIdentityCore<AppUser>().AddEntityFrameworkStores<IdentityDb>();
            services.AddDbContext<IdentityDb>(x => x.UseSqlServer("server=.;Database=IdentityDb; integrated security=true;"));
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<IdentityDb>();
        }
    }
}
