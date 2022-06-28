using Newtonsoft.Json;

namespace WasteRecords.Core.Helpers
{
    public class Response
    {
        public string StatusCode { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public Error Errors { get; set; }
    }
    public class Response<T>
    {
        public string StatusCode { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public Error Errors { get; set; }
        public T Content { get; set; }
    }

    public class Error
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public string TraceId { get; set; }
        public Dictionary<string, List<string>> Errors { get; set; }
    }
}
