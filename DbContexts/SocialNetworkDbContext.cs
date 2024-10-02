using Microsoft.EntityFrameworkCore;

namespace SocialNetwork.DbContexts
{
    public class SocialNetworkDbContext : DbContext
    {
        public SocialNetworkDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
    }
}
