

using System.Net;
using System.Text.RegularExpressions;

namespace UtmBuilder.Core.ValueObjects.Exceptions
{
    public partial class InvalidUrlException : Exception
    {
        private const string DefaultErrorMessage = "Invalid URL";
        
        public InvalidUrlException(string message = DefaultErrorMessage)
            : base(message)
        {

        }
        public static void ThrowIfInvalid( 
            string address, 
            string message = DefaultErrorMessage)
        {
            if(string.IsNullOrEmpty(address))
                throw new InvalidUrlException(message);

            if ( !UrlRegex().IsMatch( input: address ) )
                throw new InvalidUrlException();

        }

        [GeneratedRegex( "^(http:\\/\\/www\\.|https:\\/\\/www\\.|http:\\/\\/|https:\\/\\/)?[a-z0-9]+([\\-\\.]{1}[a-z0-9]+)*\\.[a-z]{2,5}(:[0-9]{1,5})?(\\/.*)?$" )]
        private static partial Regex UrlRegex();
    }
}
