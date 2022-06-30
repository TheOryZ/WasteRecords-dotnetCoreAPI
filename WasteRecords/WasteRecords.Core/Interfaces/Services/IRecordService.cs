using WasteRecords.Core.Entities;

namespace WasteRecords.Core.Interfaces.Services
{
    public interface IRecordService : IGenericService<Record>
    {
        Task<List<Record>> GetAllWithParametersAsync();
        Task<Record> GetByIdWithParametersAsync(int id);
    }
}
