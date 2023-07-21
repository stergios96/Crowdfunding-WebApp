using System.ComponentModel.DataAnnotations;

namespace Crowdfunding_WebApp.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string? CreatorName { get; set; }
        public string? ProjectTitle { get; set; }
        public string? ProjectDescription { get; set; }
        public decimal CurrentAmountFunded
        {
            get => Math.Abs(_currentAmount);
            set => _currentAmount = value;
        }
        public decimal FundingGoal
        {
            get => Math.Abs(_fundingGoal);
            set => _fundingGoal = value;
        }
        private decimal _fundingGoal;
        private decimal _currentAmount;

        public int ProjectCreatorId { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<Rewards>? Rewards { get; set; }

    }

}



