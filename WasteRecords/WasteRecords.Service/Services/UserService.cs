using WasteRecords.Core.Entities;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Core.Interfaces.Services;

namespace WasteRecords.Service.Services
{
    public class UserService : GenericService<User>, IUserService
    {
        private readonly IGenericRepository<User> _genericRepository;
        private readonly IUserRepository _userRepository;
        public UserService(IGenericRepository<User> genericRepository, IUserRepository userRepository) : base(genericRepository)
        {
            _genericRepository = genericRepository;
            _userRepository = userRepository;
        }
        public async Task<User> CheckUserAsync(User user)
        {
            return await _userRepository.CheckUserAsync(user);
        }
    }
}
