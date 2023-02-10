namespace UtlBuilder.Core.ValueObjects;

public class Url:ValueObject

{ 
	    public Url()
	{
		var url = new Url(address: "");
		Url.Address;
	}
	public Url(string address)
	{
		Address= address;

	}
	public string Address { get; }

  
}
