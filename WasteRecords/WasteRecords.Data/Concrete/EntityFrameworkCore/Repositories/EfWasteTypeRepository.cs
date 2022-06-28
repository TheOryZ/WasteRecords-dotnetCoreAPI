using WasteRecords.Core.Entities;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Data.Concrete.EntityFrameworkCore.Context;

namespace WasteRecords.Data.Concrete.EntityFrameworkCore.Repositories
{
    public class EfWasteTypeRepository : EfGenericRepository<WasteType>, IWasteTypeRepository
    {
        private readonly AppDbContext _context;
        public EfWasteTypeRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
