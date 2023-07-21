using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Crowdfunding_WebApp.Models
{
    public class Backer
    {
        [Key]
        public int BackerId { get; set; }

        [Remote("IsUserNameUnique", "Backers", HttpMethod = "POST", ErrorMessage = "Username already exists.")]
        public string BackerName { get; set; }
    }
}
