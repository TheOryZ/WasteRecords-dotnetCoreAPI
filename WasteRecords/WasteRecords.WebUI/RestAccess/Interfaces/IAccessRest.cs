using WasteRecords.WebUI.Models;

namespace WasteRecords.WebUI.RestAccess.Interfaces
{
    public interface IAccessRest
    {
        ResponseState<T> GetMethod<T>(string uri, Dictionary<string, string> headers = null);
        ResponseState<T> PostMethod<T>(object obj, string uri, Dictionary<string, string> headers = null);
        ResponseState<T> PutMethod<T>(object obj, string uri, Dictionary<string, string> headers = null);
        ResponseState<T> PutMethod<T>(string uri, Dictionary<string, string> headers = null);
        ResponseState<T> DeleteMethod<T>(string uri, Dictionary<string, string> headers = null);
    }
}
