using WasteRecords.Core.Entities;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Data.Concrete.EntityFrameworkCore.Context;

namespace WasteRecords.Data.Concrete.EntityFrameworkCore.Repositories
{
    public class EfReceivingCompanyRepository : EfGenericRepository<ReceivingCompany>, IReceivingCompanyRepository
    {
        private readonly AppDbContext _context;
        public EfReceivingCompanyRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
