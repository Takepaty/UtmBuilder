using System.Text.RegularExpressions;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtlBuilder.Core.ValueObjects;

public class Url:ValueObject

{
	

    /// <summary>
    /// Create a new URL
    /// </summary>
    /// <param name="address">Address of URL (Web site link)</param>
    public Url(string address)
	{
		Address= address;
		InvalidUrlException.ThrowIfInvalid(address);
	}

	/// <summary>
	///  Address of URL (Web site link)
	/// </summary>
	public string Address { get; }  
}
