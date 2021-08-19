using Core.Repositories.Base;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly BookstoreContext _booksotreContext;
        public Repository(BookstoreContext booksotreContext)
        {
            _booksotreContext = booksotreContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _booksotreContext.Set<T>().AddAsync(entity);
            await _booksotreContext.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteAsync(T entity)
        {
            _booksotreContext.Set<T>().Remove(entity);
            await _booksotreContext.SaveChangesAsync();
        }
        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _booksotreContext.Set<T>().ToListAsync();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _booksotreContext.Set<T>().FindAsync(id);
        }
        //public async Task UpdateAsync()
        //{
        //    await _booksotreContext.SaveChangesAsync();
        //}
        public async Task UpdateAsync(T entity)
        {
            await _booksotreContext.SaveChangesAsync();
        }
    }
}
