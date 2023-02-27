using BussinessManagementApp.DataAccess.Contexts;
using BussinessManagementApp.DataAccess.Interfaces;
using BussinessManagementApp.DataAccess.Repositories;
using BussinessManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManagementApp.DataAccess.UnitOfWork
{
    public class Uow : IUow
    {
        readonly BussinesManagementDbContext _context;

        public Uow(BussinesManagementDbContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
