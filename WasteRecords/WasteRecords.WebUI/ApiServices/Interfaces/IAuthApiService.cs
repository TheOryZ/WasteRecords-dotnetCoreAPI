using WasteRecords.WebUI.Models.UserModels;

namespace WasteRecords.WebUI.ApiServices.Interfaces
{
    public interface IAuthApiService
    {
        bool SignIn(SignInViewModel model);
    }
}
