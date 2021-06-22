using Microsoft.EntityFrameworkCore;
using Shop.Core.Domain;

namespace Shop.Db
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Collar> CollarDbSet { get; set; }
        public DbSet<NormalLeash> NormalLeashDbSet { get; set; }
        public DbSet<Order> OrderDbSet { get; set; }
        public DbSet<ReversibleLeash> ReversibleLeashDbSet { get; set; }
        public DbSet<Suspenders> SuspendersDbSet { get; set; }
        public DbSet<TrainingLeash> TrainingLeashDbSet { get; set; }
        public DbSet<User> UserDbSet { get; set; }

        public ShopDbContext(DbContextOptions options) : base(options)
        {

        }

        protected void onModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>()
                .HasMany(x => x.Products)
                .WithOne(id => id.Order)
                .HasForeignKey(fk => fk.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<TapeBase>()
                .ToTable("TapeBaseDbSet")
                .HasDiscriminator<string>("Tapes")
                .HasValue<Collar>("Collars")
                .HasValue<NormalLeash>("NormalLeashes")
                .HasValue<ReversibleLeash>("ReversibleLeashes")
                .HasValue<Suspenders>("Suspenders")
                .HasValue<TrainingLeash>("TrainingLeashes");

            builder.Entity<Product>()
                .HasMany(x => x.Collars)
                .WithOne(p => p.Product)
                .HasForeignKey(fk => fk.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Product>()
                .HasMany(x => x.NormalLeashes)
                .WithOne(p => p.Product)
                .HasForeignKey(fk => fk.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Product>()
                .HasMany(x => x.ReversibleLeashes)
                .WithOne(p => p.Product)
                .HasForeignKey(fk => fk.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Product>()
                .HasMany(x => x.Suspenders)
                .WithOne(p => p.Product)
                .HasForeignKey(fk => fk.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Product>()
                .HasMany(x => x.TrainingLeashes)
                .WithOne(p => p.Product)
                .HasForeignKey(fk => fk.ProductId)
                .OnDelete(DeleteBehavior.NoAction);
        }

                
    }
}
