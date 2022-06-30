namespace WasteRecords.WebUI.Models
{
    public class ResponseState
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public Dictionary<string, List<string>> Errors { get; set; }
    }
    public class ResponseState<T>
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public Dictionary<string, List<string>> Errors { get; set; }
        public T Content { get; set; }
    }
}
