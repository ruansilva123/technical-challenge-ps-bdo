namespace CorporateResources.Exceptions.Common
{
    public class ApiException : Exception
    {
        public int StatusCode { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
    }
}
