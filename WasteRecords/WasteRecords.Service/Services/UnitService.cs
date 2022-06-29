using WasteRecords.Core.Entities;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Core.Interfaces.Services;

namespace WasteRecords.Service.Services
{
    public class UnitService : GenericService<Unit>, IUnitService
    {
        private readonly IGenericRepository<Unit> _genericRepository;
        public UnitService(IGenericRepository<Unit> genericRepository) : base(genericRepository)
        {
            _genericRepository = genericRepository;
        }
    }
}
