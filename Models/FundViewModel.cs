using System.Collections.Generic;

namespace Crowdfunding_WebApp.Models
{
    public class FundViewModel
    {
        public int ProjectId { get; set; }
        public string? ProjectTitle { get; set; }
        public string? ProjectDescription { get; set; }
        public decimal FundingGoal { get; set; }
        public decimal CurrentAmountFunded { get; set; }
        public List<Rewards>? AvailableRewards { get; set; }
        public List<int>? SelectedRewardIds { get; set; }
        public string? BackerName { get; set; } 
    }
}
