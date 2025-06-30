using CorporateResources.Exceptions.Common;

namespace CorporateResources.Exceptions
{
    public class BadRequestException : ApiException
    {
        public BadRequestException(string message)
        {
            StatusCode = 400;
            ErrorMessage = message;
        }
    }
}
