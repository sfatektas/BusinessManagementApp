﻿using BussinessManagementApp.DataAccess.Contexts;
using BussinessManagementApp.DataAccess.Interfaces;
using BussinessManagementApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManagementApp.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly BussinesManagementDbContext _context;

        public Repository(BussinesManagementDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task<T> FindAsync(object id)
        {
            var data = await _context.Set<T>().FindAsync(id);
            return data;
        }

        public async Task<List<T>> GetAllAsync()
        {
            var list = await _context.Set<T>().AsNoTracking().ToListAsync();
            return list;
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter)
        {
            var list = await _context.Set<T>().AsNoTracking().Where(filter).ToListAsync();
            return list;
        }

        public async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter, bool asNoTracking = false)
        {
            return !asNoTracking ? await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter) :
                await _context.Set<T>().SingleOrDefaultAsync(filter);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T updated)
        {
            //_context.Set<T>().Update(updated);
            _context.Entry<T>(updated).State = EntityState.Modified; // Sorunumu bu yapı çözdü .
        }
        public IQueryable<T> GetQueryable()
        {
            return _context.Set<T>().AsQueryable();
        }
        public IQueryable<T> GetQueryable(int id)
        {
            return _context.Set<T>().AsQueryable().Where(x => x.Id == id);
        }
    }
}
