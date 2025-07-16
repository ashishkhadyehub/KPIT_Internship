using dotnetcoreSessions.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetcoreSessions.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Students> Students { get; set; }

    }
}
