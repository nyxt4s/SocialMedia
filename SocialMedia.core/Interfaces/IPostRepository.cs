﻿
using SocialMedia.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMedia.core.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetPosts();
        Task<Post> GetPost(int id);
        Task InsertPost(Post post);
    }
}
