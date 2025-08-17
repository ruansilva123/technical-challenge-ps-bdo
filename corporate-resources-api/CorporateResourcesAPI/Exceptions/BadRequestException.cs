using CorporateResourcesAPI.Exceptions.Common;

namespace CorporateResourcesAPI.Exceptions
{
    public class BadRequestException : BaseException
    {
        public BadRequestException(int statusCode, string message)
            : base(statusCode, message)
        {
        }
    }
}
