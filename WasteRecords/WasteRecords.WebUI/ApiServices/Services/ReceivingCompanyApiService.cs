using WasteRecords.WebUI.ApiServices.Interfaces;
using WasteRecords.WebUI.Models;
using WasteRecords.WebUI.Models.ReceivingCompany;
using WasteRecords.WebUI.RestAccess.Interfaces;

namespace WasteRecords.WebUI.ApiServices.Services
{
    public class ReceivingCompanyApiService : IReceivingCompanyApiService
    {
        private readonly IAccessRest _accessRest;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string url;
        public ReceivingCompanyApiService(IAccessRest accessRest, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _accessRest = accessRest;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            url = _configuration.GetValue<string>("ApiInfo:uri");
        }
        public ResponseState<List<ReceivingCompanyListViewModel>> GetAll()
        {
            var uri = string.Format("{0}/{1}", url, "ReceivingCompany");
            return _accessRest.GetMethod<List<ReceivingCompanyListViewModel>>(uri);
        }
    }
}
