using Crowdfunding_WebApp.Models;
using System.ComponentModel.DataAnnotations;

public class BackedProjects
{
    [Key]
    public int BackedProjectId { get; set; }
    public int BackerId { get; set; }
    public int ProjectId { get; set; }
    public decimal Amount { get; set; }

    public Project Project { get; set; }
}
