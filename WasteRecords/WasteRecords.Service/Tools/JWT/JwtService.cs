using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WasteRecords.Core.Entities;
using WasteRecords.Core.Helpers;

namespace WasteRecords.Service.Tools.JWT
{
    internal class JwtService : IJwtService
    {
        private readonly IOptions<JwtInfo> _optionsJwt;
        public JwtService(IOptions<JwtInfo> optionsJwt)
        {
            _optionsJwt = optionsJwt;
        }
        public JwtToken GenerateJwt(User user)
        {
            var jwtInfo = _optionsJwt.Value;

            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtInfo.SecurityKey));
            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(issuer: jwtInfo.Issuer, audience: jwtInfo.Audience,
                claims: SetClaims(user), notBefore: DateTime.Now, expires: DateTime.Now.AddMinutes(jwtInfo.Expires),
                signingCredentials: signingCredentials);

            JwtToken jwtToken = new JwtToken();
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            jwtToken.Token = handler.WriteToken(jwtSecurityToken);
            return jwtToken;
        }
        private List<Claim> SetClaims(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            return claims;
        }
    }
}
