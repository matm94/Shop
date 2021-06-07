using Microsoft.EntityFrameworkCore;
using Shop.Core.Domain;

namespace Shop.Db
{
    public class ShopDbContext : DbContext
    {
        public DbSet<User> UserDbSet { get; set; }
        public DbSet<Order> OrderDbSet { get; set; }
        public ShopDbContext(DbContextOptions options) : base(options)
        {

        }

        protected void onModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>()
                .HasOne(sp => sp.Shipment)
                .WithOne(o => o.Order)
                .HasForeignKey<Shipment>(key => key.OrderId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
