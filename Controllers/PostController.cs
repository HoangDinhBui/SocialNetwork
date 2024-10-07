using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.DTOs;
using SocialNetwork.Services;

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly PostService _postService;
        public PostController(PostService postService)
        {
            _postService = postService;
        }
        [HttpPost("Create")]
        public IActionResult CreatePost([FromBody] CreatePostRequest postRequest)
        {
            var createPost = _postService.CreatePost(postRequest);
            if (createPost != null)
            {
                return BadRequest("Failed to create post.");
            }

            return Ok(createPost);
        }
    }
}
