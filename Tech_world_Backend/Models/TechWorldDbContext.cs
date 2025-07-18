using Microsoft.EntityFrameworkCore;
using Tech_world_Backend.Models.UserProfile;

namespace Tech_world_Backend.Models
{
    public class TechWorldDbContext :DbContext
    {
        public TechWorldDbContext(DbContextOptions<TechWorldDbContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.UserAddress)
                .WithOne(a => a.User)
                .HasForeignKey<UserAddress>(a => a.UserId);
        }
    }
}
