using Microsoft.EntityFrameworkCore;
using WasteRecords.Core.Entities;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Data.Concrete.EntityFrameworkCore.Context;

namespace WasteRecords.Data.Concrete.EntityFrameworkCore.Repositories
{
    public class EfUserRepository : EfGenericRepository<User>, IUserRepository
    {
        private readonly AppDbContext _context;
        public EfUserRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> CheckUserAsync(User user)
        {
            return await _context.Users.SingleOrDefaultAsync(x => x.Email == user.Email && x.Password == user.Password); //TODO: will need to change this method later.
        }
    }
}
