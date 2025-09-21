using Microsoft.EntityFrameworkCore;
using IndianPincode.Models;

namespace IndianPincode.Data
{
    public class PincodeContext : DbContext
    {
        public PincodeContext(DbContextOptions<PincodeContext> options) : base(options)
        {
        }

        public DbSet<IndiaPincodeData> IndiaPincodeData { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IndiaPincodeData>().HasNoKey();
            base.OnModelCreating(modelBuilder);
        }
    }
}
