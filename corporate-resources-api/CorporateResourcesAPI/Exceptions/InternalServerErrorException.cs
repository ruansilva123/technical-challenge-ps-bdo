using CorporateResourcesAPI.Exceptions.Common;

namespace CorporateResourcesAPI.Exceptions
{
    public class InternalServerErrorException : BaseException
    {
        public InternalServerErrorException(int statusCode, string message)
            : base(statusCode, message)
        {
        }
    }
}
