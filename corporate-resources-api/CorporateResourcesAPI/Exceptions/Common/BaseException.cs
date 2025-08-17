namespace CorporateResourcesAPI.Exceptions.Common
{
    public class BaseException : Exception
    {
        public int StatusCode { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
    }
}
