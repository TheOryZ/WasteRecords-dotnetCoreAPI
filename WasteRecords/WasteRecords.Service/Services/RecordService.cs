using WasteRecords.Core.Entities;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Core.Interfaces.Services;

namespace WasteRecords.Service.Services
{
    public class RecordService : GenericService<Record>, IRecordService
    {
        private readonly IGenericRepository<Record> _genericRepository;
        private readonly IRecordRepository _recordRepository;

        public RecordService(IGenericRepository<Record> genericRepository, IRecordRepository recordRepository) : base(genericRepository)
        {
            _genericRepository = genericRepository;
            _recordRepository = recordRepository;
        }

        public async Task<List<Record>> GetAllWithParametersAsync()
        {
            return await _recordRepository.GetAllWithParametersAsync();
        }

        public async Task<Record> GetByIdWithParametersAsync(int id)
        {
            return await _recordRepository.GetByIdWithParametersAsync(id);
        }
    }
}
