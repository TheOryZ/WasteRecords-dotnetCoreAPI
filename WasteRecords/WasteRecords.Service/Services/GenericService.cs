using WasteRecords.Core.Interfaces;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Core.Interfaces.Services;

namespace WasteRecords.Service.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly IGenericRepository<TEntity> _genericRepository;
        public GenericService(IGenericRepository<TEntity> genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public async Task AddAsync(TEntity entity)
        {
            await _genericRepository.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _genericRepository.AddRangeAsync(entities);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _genericRepository.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _genericRepository.GetByIdAsync(id);
        }

        public void Remove(TEntity entity)
        {
            _genericRepository.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _genericRepository.RemoveRange(entities);
        }

        public TEntity Update(TEntity entity)
        {
            return _genericRepository.Update(entity);
        }

        public async Task<IEnumerable<TEntity>> WhereAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return await _genericRepository.WhereAsync(predicate);
        }
    }
}
