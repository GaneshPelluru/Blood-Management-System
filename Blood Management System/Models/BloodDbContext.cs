using Blood_Management_System.Models;
using Microsoft.EntityFrameworkCore;
namespace BloodDonor.Models
{
    public class BloodDbContext : DbContext
    {
        public BloodDbContext(DbContextOptions<BloodDbContext> options) : base(options)
        {
        }
        public DbSet<Blood> Bloods { get; set; }

    }
}