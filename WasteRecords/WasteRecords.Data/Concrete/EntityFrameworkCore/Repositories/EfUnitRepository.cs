using WasteRecords.Core.Entities;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Data.Concrete.EntityFrameworkCore.Context;

namespace WasteRecords.Data.Concrete.EntityFrameworkCore.Repositories
{
    public class EfUnitRepository : EfGenericRepository<Unit>, IUnitRepository
    {
        private readonly AppDbContext _context;
        public EfUnitRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
