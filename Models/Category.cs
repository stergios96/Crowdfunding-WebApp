namespace Crowdfunding_WebApp.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public List<Project>? Projects { get; set; }
    }
}
