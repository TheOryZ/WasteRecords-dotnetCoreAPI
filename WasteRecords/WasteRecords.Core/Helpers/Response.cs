namespace WasteRecords.Core.Helpers
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public Dictionary<string, List<string>> Errors { get; set; }
    }
    public class Response<T>
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public Dictionary<string, List<string>> Errors { get; set; }
        public T Content { get; set; }
    }
}
