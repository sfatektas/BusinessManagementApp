using BussinessManagementApp.Entities.IdentityEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManagementApp.DataAccess.Contexts
{
    public class IdentityDb : IdentityDbContext<AppUser,AppRole,int>
    {
        public IdentityDb(DbContextOptions<IdentityDb> opt) : base(opt) { }
    }
}
