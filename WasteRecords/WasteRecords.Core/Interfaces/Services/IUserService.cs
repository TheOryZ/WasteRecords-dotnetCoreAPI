using WasteRecords.Core.Entities;

namespace WasteRecords.Core.Interfaces.Services
{
    public interface IUserService : IGenericService<User>
    {
        Task<User> CheckUserAsync(User user);
    }
}
