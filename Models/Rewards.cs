using System.ComponentModel.DataAnnotations;

namespace Crowdfunding_WebApp.Models
{
    public class Rewards
    {
        [Key] public int RewardsId { get; set; }
        public int ProjectId { get; set; }
        public string? RewardsTitle { get; set;}
        public string? RewardsDescription { get; set;}
        public decimal Amount
        {
            get => Math.Abs(_amount);
            set => _amount = value;
        }
        private decimal _amount;

    }

}
