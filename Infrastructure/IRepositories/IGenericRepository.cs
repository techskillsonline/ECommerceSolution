using Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.IRepositories
{
    public interface IGenericRepository<T> where T:BaseEntity
    {
        public Task<T?> GetAsync(int id);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<bool> AddAsync(T obj);
        public Task<bool> AddAsync(List<T> lst);
        public Task<bool> UpdateAsync(T obj);
        public Task<bool> DeleteAsync(int Id);

        public Task<IEnumerable<T>> GetAsync(Func<T,bool> condition);

    }
}
