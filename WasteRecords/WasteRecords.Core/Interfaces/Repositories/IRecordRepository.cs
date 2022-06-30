using WasteRecords.Core.Entities;

namespace WasteRecords.Core.Interfaces.Repositories
{
    public interface IRecordRepository : IGenericRepository<Record>
    {
        Task<List<Record>> GetAllWithParametersAsync();
        Task<Record> GetByIdWithParametersAsync(int id);
    }
}
