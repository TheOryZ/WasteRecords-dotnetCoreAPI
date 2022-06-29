using WasteRecords.Core.Entities;

namespace WasteRecords.Service.Tools.JWT
{
    public interface IJwtService
    {
        JwtToken GenerateJwt(User user);
    }
}
