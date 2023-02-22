using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IWriteRepository<T>: IRepository<T> where T :BaseEntity,ItemEntity
    {
        Task AddAsync(T model);
        Task RemoveAsync(T model);
        Task UpdateAsync(T model, int id);
        Task<T> UpdateAsyncWithModel(T model, int id);
        Task<IDbContextTransaction> DbTransactional();
        Task<T> AddAsyncWithModel(T model);
        Task AddRangeAsync(IEnumerable<T> models);
        Task UpdateAsyncModel(T model);
        Task<T> UpdateAsyncWithModel(T model);

    }
}
