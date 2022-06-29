using WasteRecords.Core.Entities;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Core.Interfaces.Services;

namespace WasteRecords.Service.Services
{
    public class WasteTypeService :GenericService<WasteType>, IWasteTypeService
    {
        private readonly IGenericRepository<WasteType> _genericRepository;
        public WasteTypeService(IGenericRepository<WasteType> genericRepository) : base(genericRepository)
        {
            _genericRepository = genericRepository;
        }
    }
}
