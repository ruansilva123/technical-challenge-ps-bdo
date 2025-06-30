using CorporateResources.Exceptions.Common;

namespace CorporateResources.Exceptions
{
    public class InternalServerErrorException : ApiException
    {
        public InternalServerErrorException(string message)
        {
            StatusCode = 500;
            ErrorMessage = message;
        }
    }
}
