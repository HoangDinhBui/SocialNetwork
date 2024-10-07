using SocialNetwork.DTOs;
using SocialNetwork.Entities;
using SocialNetwork.Repositories;

namespace SocialNetwork.Services;
public class PostService
{
    private readonly PostRepository _postRepository;

    public PostService(PostRepository postRepository)
    {
        _postRepository = postRepository; 
    }

    public Post CreatePost(CreatePostRequest postRequest)
    {
        var post = new Post
        {
            Content = postRequest.Content
        };
        _postRepository.AddPost(post);
        return post;
    }
}
