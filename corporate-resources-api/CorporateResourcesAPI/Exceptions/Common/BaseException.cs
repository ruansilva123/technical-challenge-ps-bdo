namespace CorporateResourcesAPI.Exceptions.Common
{
    public class BaseException : Exception
    {
        public BaseException(int statusCode, string message)
        {
            StatusCode = statusCode;
            ErrorMessage = message;
        }

        public int StatusCode { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
    }
}
