using Microsoft.EntityFrameworkCore;
using Shop.Core.Domain;

namespace Shop.Db
{
    public class ShopDbContext : DbContext
    {
        public DbSet<User> UserDbSet { get; set; }
        public ShopDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
