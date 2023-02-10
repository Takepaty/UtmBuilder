using System.Text.RegularExpressions;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtlBuilder.Core.ValueObjects;

public class Url:ValueObject

{
	private const string UrlRegexPattern =
		@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$";


    /// <summary>
    /// Create a new URL
    /// </summary>
    /// <param name="address">Address of URL (Web site link)</param>
    public Url(string address)
	{
		Address= address;
		if ( Regex.IsMatch( input: Address, UrlRegexPattern ) )
			throw new InvalidUrlException( );

	}

	/// <summary>
	///  Address of URL (Web site link)
	/// </summary>
	public string Address { get; }  
}
