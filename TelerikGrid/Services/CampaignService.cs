namespace TelerikGrid.Services;

using TelerikGrid.Models;

public class CampaignService
{
    public Task<List<Campaign>> GetCampaignsAsync()
    {
        return Task.FromResult(new List<Campaign>
        {
            new Campaign
            {
                Id = 1,
                CampaignName = "Other Campaign",
                Active = true,
                RoutingMode = "Round Robin",
                AssignedExperts = 2,
                LiveRouteUrl = "http://example.com/campaign1",
                TrafficSource = "Website",
                Availability = "24/7"
            },
            new Campaign
            {
                Id = 2,
                CampaignName = "Social Media Outreach",
                Active = false,
                RoutingMode = "Round Robin",
                AssignedExperts = 23,
                LiveRouteUrl = "http://example.com/campaign1",
                TrafficSource = "Mobile App",
                Availability = "During Specific Hours"
            },
            new Campaign
            {
                Id = 1,
                CampaignName = "Other Campaign",
                Active = true,
                RoutingMode = "Round Robin",
                AssignedExperts = 2,
                LiveRouteUrl = "http://example.com/campaign1",
                TrafficSource = "Website",
                Availability = "24/7"
            },
            new Campaign
            {
                Id = 2,
                CampaignName = "Social Media Outreach",
                Active = false,
                RoutingMode = "Round Robin",
                AssignedExperts = 23,
                LiveRouteUrl = "http://example.com/campaign1",
                TrafficSource = "Mobile App",
                Availability = "During Specific Hours"
            },
            new Campaign
            {
                Id = 1,
                CampaignName = "Other Campaign",
                Active = true,
                RoutingMode = "Round Robin",
                AssignedExperts = 2,
                LiveRouteUrl = "http://example.com/campaign1",
                TrafficSource = "Website",
                Availability = "24/7"
            },
            new Campaign
            {
                Id = 2,
                CampaignName = "Social Media Outreach",
                Active = false,
                RoutingMode = "Round Robin",
                AssignedExperts = 23,
                LiveRouteUrl = "http://example.com/campaign1",
                TrafficSource = "Mobile App",
                Availability = "During Specific Hours"
            },
            new Campaign
            {
                Id = 1,
                CampaignName = "Other Campaign",
                Active = true,
                RoutingMode = "Round Robin",
                AssignedExperts = 2,
                LiveRouteUrl = "http://example.com/campaign1",
                TrafficSource = "Website",
                Availability = "24/7"
            },
            new Campaign
            {
                Id = 2,
                CampaignName = "Social Media Outreach",
                Active = false,
                RoutingMode = "Round Robin",
                AssignedExperts = 23,
                LiveRouteUrl = "http://example.com/campaign1",
                TrafficSource = "Mobile App",
                Availability = "During Specific Hours"
            },
            new Campaign
            {
                Id = 1,
                CampaignName = "Other Campaign",
                Active = true,
                RoutingMode = "Round Robin",
                AssignedExperts = 2,
                LiveRouteUrl = "http://example.com/campaign1",
                TrafficSource = "Website",
                Availability = "24/7"
            },
            new Campaign
            {
                Id = 2,
                CampaignName = "Social Media Outreach",
                Active = false,
                RoutingMode = "Round Robin",
                AssignedExperts = 23,
                LiveRouteUrl = "http://example.com/campaign1",
                TrafficSource = "Mobile App",
                Availability = "During Specific Hours"
            },
            new Campaign
            {
                Id = 1,
                CampaignName = "Other Campaign",
                Active = true,
                RoutingMode = "Round Robin",
                AssignedExperts = 2,
                LiveRouteUrl = "http://example.com/campaign1",
                TrafficSource = "Website",
                Availability = "24/7"
            },
            new Campaign
            {
                Id = 2,
                CampaignName = "Social Media Outreach",
                Active = false,
                RoutingMode = "Round Robin",
                AssignedExperts = 23,
                LiveRouteUrl = "http://example.com/campaign1",
                TrafficSource = "Mobile App",
                Availability = "During Specific Hours"
            },
        });
    }
}