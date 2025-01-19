namespace Azon.Business
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public required T Value { get; set; }
    }
}
