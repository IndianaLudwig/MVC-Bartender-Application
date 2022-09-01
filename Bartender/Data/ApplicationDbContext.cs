using Bartender.Models;
using Microsoft.EntityFrameworkCore;

namespace Bartender.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlite(@"Data Source=.\Bartender.db");

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<BarMenueModel> BarMenue { get; set; }

        public DbSet<BarQueueModel> BarQueue { get; set; }

        public DbSet<BarStaff> BarStaff { get; set; }
    }
}
