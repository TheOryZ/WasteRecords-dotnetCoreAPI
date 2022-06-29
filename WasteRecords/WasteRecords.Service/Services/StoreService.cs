using WasteRecords.Core.Entities;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Core.Interfaces.Services;

namespace WasteRecords.Service.Services
{
    public class StoreService : GenericService<Store>, IStoreService
    {
        private readonly IGenericRepository<Store> _genericRepository;
        public StoreService(IGenericRepository<Store> genericRepository) : base(genericRepository)
        {
            _genericRepository = genericRepository;
        }
    }
}
