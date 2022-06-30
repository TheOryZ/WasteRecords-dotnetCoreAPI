using Microsoft.EntityFrameworkCore;
using WasteRecords.Core.Entities;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Data.Concrete.EntityFrameworkCore.Context;

namespace WasteRecords.Data.Concrete.EntityFrameworkCore.Repositories
{
    public class EfRecordRepository : EfGenericRepository<Record>, IRecordRepository
    {
        private readonly AppDbContext _context;
        public EfRecordRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Record>> GetAllWithParametersAsync()
        {
            return await _context.Records.Include(x => x.Store)
                                        .Include(x => x.Unit)
                                        .Include(x => x.WasteType)
                                        .Include(x => x.KindOfWaste)
                                        .Include(x => x.ReceivingCompany)
                                        .Where(x => x.IsActive && !x.IsDeleted)
                                        .ToListAsync();
        }

        public async Task<Record> GetByIdWithParametersAsync(int id)
        {
            return await _context.Records.Include(x => x.Store)
                                        .Include(x => x.Unit)
                                        .Include(x => x.WasteType)
                                        .Include(x => x.KindOfWaste)
                                        .Include(x => x.ReceivingCompany)
                                        .Where(x => x.Id == id && x.IsActive && !x.IsDeleted)
                                        .FirstOrDefaultAsync();
        }
    }
}
