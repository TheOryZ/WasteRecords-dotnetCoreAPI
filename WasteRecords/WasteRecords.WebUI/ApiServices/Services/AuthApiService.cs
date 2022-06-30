using WasteRecords.WebUI.ApiServices.Interfaces;
using WasteRecords.WebUI.Models;
using WasteRecords.WebUI.Models.UserModels;
using WasteRecords.WebUI.RestAccess.Interfaces;

namespace WasteRecords.WebUI.ApiServices.Services
{
    public class AuthApiService : IAuthApiService
    {
        private readonly IAccessRest _accessRest;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string url;
        public AuthApiService(IAccessRest accessRest, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _accessRest = accessRest;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            url = _configuration.GetValue<string>("ApiInfo:uri");
        }
        public bool SignIn(SignInViewModel model)
        {
            var uri = string.Format("{0}/{1}", url, "Auth/SignIn");
            var response = _accessRest.PostMethod<JwtTokenModel>(model, uri);
            if (response.IsSuccess)
            {
                var token = response.Content.token;
                //_httpContextAccessor.HttpContext.Session.SetString("token", token);
                return true;
            }
            return false;
        }
    }
}
