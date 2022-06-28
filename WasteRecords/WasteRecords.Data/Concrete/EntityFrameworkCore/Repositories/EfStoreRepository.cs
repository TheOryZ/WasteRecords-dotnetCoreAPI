using WasteRecords.Core.Entities;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Data.Concrete.EntityFrameworkCore.Context;

namespace WasteRecords.Data.Concrete.EntityFrameworkCore.Repositories
{
    public class EfStoreRepository : EfGenericRepository<Store>, IStoreRepository
    {
        private readonly AppDbContext _context;
        public EfStoreRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
