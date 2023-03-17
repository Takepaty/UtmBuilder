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

    public override string ToString()
    {
        var segments = new List<string>();

        segments.AddIfNotNull("utm_source",Campaign.Source);    
        segments.AddIfNotNull("utm_medium",Campaign.Medium);    
        segments.AddIfNotNull("utm_campaign",Campaign.Name);    
        segments.AddIfNotNull("utm_id",Campaign.Id);    
        segments.AddIfNotNull("utm_term",Campaign.Term);    
        segments.AddIfNotNull("utm_content",Campaign.Content);    

                
        return $"{Url.Address}?{string.Join("&", segments)}";

    }
}
