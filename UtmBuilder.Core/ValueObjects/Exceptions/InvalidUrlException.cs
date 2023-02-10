

namespace UtmBuilder.Core.ValueObjects.Exceptions
{
    public class InvalidUrlException : Exception
    {
        public InvalidUrlException(string message = "Invalid URL")
            : base(message)
        {

        }
    }
}
