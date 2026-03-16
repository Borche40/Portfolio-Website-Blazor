using System.ComponentModel.DataAnnotations;



namespace BorchePortfolio.Models
{
    public class VisitorEntry
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string PageName { get; set; } = string.Empty;
        public DateTime VisitedAt { get; set; }= DateTime.UtcNow;
    }
}
