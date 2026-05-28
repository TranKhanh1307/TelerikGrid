namespace TelerikGrid.Models;

public class Campaign
{
    public int Id { get; set; }
    public string CampaignName { get; set; } = string.Empty;
    public bool Active { get; set; }
    public string RoutingMode { get; set; } = string.Empty;
    public int AssignedExperts { get; set; }
    public string LiveRouteUrl { get; set; } = string.Empty;
    public string TrafficSource { get; set; } = string.Empty;
    public string Availability { get; set; } = string.Empty;
}