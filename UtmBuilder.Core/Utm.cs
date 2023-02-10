using UtlBuilder.Core.ValueObjects;

namespace UtmBulder.Core;

public class Utm
{
    

    public Utm(
        Url url,
        Campaign campaign)
    {
        Url = url;
        Campaign = campaign;
    }

    /// <summary>
    /// URL (Website Link)
    /// </summary>
    public Url Url { get; }

    /// <summary>
    /// Campaign Details
    /// </summary>
    public Campaign Campaign { get;}    
}
