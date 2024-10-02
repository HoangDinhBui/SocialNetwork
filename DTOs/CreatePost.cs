using System;
using SocialNetwork.Entities;

namespace SocialNetwork.DTOs
{
    public class CreatePostRequest
    {
        public required string Content { get; set; }
    }

    public class CreatePostResponse : Post
    {

    }
}
