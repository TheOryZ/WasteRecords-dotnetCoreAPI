using WasteRecords.Core.Entities;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Data.Concrete.EntityFrameworkCore.Context;

namespace WasteRecords.Data.Concrete.EntityFrameworkCore.Repositories
{
    public class EfKindOfWasteRepository : EfGenericRepository<KindOfWaste>, IKindOfWasteRepository
    {
        private readonly AppDbContext _context;
        public EfKindOfWasteRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
