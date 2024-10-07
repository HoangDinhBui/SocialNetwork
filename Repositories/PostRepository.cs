using SocialNetwork.DbContexts;
using SocialNetwork.Entities;

namespace SocialNetwork.Repositories;
public class PostRepository
{
    private readonly SocialNetworkDbContext _dbContext;
    public PostRepository(SocialNetworkDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public bool AddPost(Post post)
    {
        _dbContext.Posts.Add(post);
        return _dbContext.SaveChanges() > 0;
    }
}
