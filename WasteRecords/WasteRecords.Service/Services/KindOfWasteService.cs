using WasteRecords.Core.Entities;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Core.Interfaces.Services;

namespace WasteRecords.Service.Services
{
    public class KindOfWasteService : GenericService<KindOfWaste>, IKindOfWasteService
    {
        private readonly IGenericRepository<KindOfWaste> _genericRepository;

        public KindOfWasteService(IGenericRepository<KindOfWaste> genericRepository) : base(genericRepository)
        {
            _genericRepository = genericRepository;
        }
    }
}
