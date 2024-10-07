using Microsoft.EntityFrameworkCore;
using SocialNetwork.Entities;

namespace SocialNetwork.DbContexts
{
    public class SocialNetworkDbContext : DbContext
    {
        public SocialNetworkDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
        public DbSet<Post> Posts { get; set; }
    }
}
