using Domain.SharedKernel;
using Infrastructure.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly DatabaseContext _db;

        public GenericRepository(DatabaseContext dbContext)
        {
            this._db = dbContext;
        }

        public async Task<bool> AddAsync(T obj)
        {
            this._db.Add(obj);
            return await this._db.SaveChangesAsync() > 0;
            
        }

        public async Task<bool> AddAsync(List<T> lst)
        {
            this._db.Set<T>().AddRange(lst);
            return await this._db.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(int Id)
        {
            T? obj = this._db.Set<T>().Find(Id);
            if(obj is not null)
            {
                this._db.Remove(obj);
                return await this._db.SaveChangesAsync() > 0;
            }
            return false;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await this._db.Set<T>().ToListAsync();
        }

        public async Task<T?> GetAsync(int id)
        {
            return await this._db.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAsync(Func<T, bool> condition)
        {
            return (await this._db.Set<T>().ToListAsync()).Where(condition);
        }

        public async Task<bool> UpdateAsync(T obj)
        {
            this._db.Remove(obj);
            return await this._db.SaveChangesAsync() > 0;
        }
    }
}
