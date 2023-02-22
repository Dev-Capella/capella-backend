using Application.Repositories;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity, ItemEntity
    {
        private readonly CapellaDbContext _context;

        public WriteRepository(CapellaDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<IDbContextTransaction> DbTransactional()
        {
            return await _context.Database.BeginTransactionAsync();
        }

        public async Task AddAsync(T model)
        {
            try
            {
                EntityEntry<T> entityEntry = Table.Add(model);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
        }

        public async Task RemoveAsync(T model)
        {
            try
            {
                EntityEntry<T> entityEntry = Table.Remove(model);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
        }

        public async Task UpdateAsync(T newModel, int id)
        {
            try
            {
                T dbModel = Table.FirstOrDefault(data => data.Id == id);

                if (dbModel == null)
                    throw new ArgumentNullException(nameof(dbModel));

                if (newModel == null)
                    throw new ArgumentNullException(nameof(newModel));

                _context.Entry(dbModel).CurrentValues.SetValues(newModel);

                foreach (var property in _context.Entry(dbModel).Properties)
                {
                    if (property.CurrentValue == null)
                    {
                        _context.Entry(dbModel).Property(property.Metadata.Name).IsModified = false;
                    }
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
        }

        public async Task<T> AddAsyncWithModel(T model)
        {
            try
            {
                EntityEntry<T> entityEntry = Table.Add(model);
                await _context.SaveChangesAsync();
                return entityEntry.Entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
        }

        public async Task AddRangeAsync(IEnumerable<T> models)
        {
            await Table.AddRangeAsync(models);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsyncModel(T model)
        {
            await Task.Run(() => { Table.Update(model); });
            await _context.SaveChangesAsync();
        }

        public async Task<T> UpdateAsyncWithModel(T model)
        {
            await Task.Run(() => { Table.Update(model); });
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<T> UpdateAsyncWithModel(T model, int id)
        {
            try
            {
                T dbModel = Table.FirstOrDefault(data => data.Id == id);

                if (dbModel == null)
                    throw new ArgumentNullException(nameof(dbModel));

                if (model == null)
                    throw new ArgumentNullException(nameof(model));

                // Update each property in the database model with the corresponding value from the model object
                var properties = typeof(T).GetProperties()
                    .Where(p => p.PropertyType.Namespace == "System" && p.CanWrite);
                foreach (var property in properties)
                {
                    var modelValue = property.GetValue(model);
                    var dbValue = property.GetValue(dbModel);

                    if (modelValue != null && !modelValue.Equals(dbValue))
                    {
                        _context.Entry(dbModel).Property(property.Name).CurrentValue = modelValue;
                    }
                }


                await _context.SaveChangesAsync();
                return dbModel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
        }
    }
}