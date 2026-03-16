using Microsoft.EntityFrameworkCore;
using BorchePortfolio.Models;


namespace BorchePortfolio.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<ContactMessage> ContactMessages => Set<ContactMessage>();
    
        public DbSet<VisitorEntry> VisitorEntries => Set<VisitorEntry>();
    }
}
