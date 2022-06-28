using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WasteRecords.Core.Interfaces;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Data.Concrete.EntityFrameworkCore.Context;

namespace WasteRecords.Data.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity, new()
    {
        protected readonly AppDbContext _context;
        public EfGenericRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(TEntity entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _context.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().Where(x => x.IsDeleted == false).ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public void Remove(TEntity entity)
        {
            entity.IsDeleted = true;
            _context.Update(entity);
            _context.SaveChanges();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            foreach (TEntity item in entities)
            {
                item.IsDeleted = true;
            }
            _context.UpdateRange(entities);
            _context.SaveChanges();
        }

        public TEntity Update(TEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> WhereAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().Where(predicate).ToListAsync();
        }
    }
}
