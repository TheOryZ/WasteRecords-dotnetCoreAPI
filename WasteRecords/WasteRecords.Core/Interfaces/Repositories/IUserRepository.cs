using WasteRecords.Core.Entities;

namespace WasteRecords.Core.Interfaces.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> CheckUserAsync(User user);
    }
}
