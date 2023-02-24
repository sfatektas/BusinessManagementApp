using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManagementApp.DataAccess.Contexts
{
    public class BussinesManagementDb : DbContext
    {
        public BussinesManagementDb(DbContextOptions<BussinesManagementDb>opt): base(opt) { }

    }
}
