using WasteRecords.Core.Entities;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Core.Interfaces.Services;

namespace WasteRecords.Service.Services
{
    public class RecordService : GenericService<Record>, IRecordService
    {
        private readonly IGenericRepository<Record> _genericRepository;

        public RecordService(IGenericRepository<Record> genericRepository) : base(genericRepository)
        {
            _genericRepository = genericRepository;
        }
    }
}
