﻿using Microsoft.EntityFrameworkCore;
using SocialMedia.core.Interfaces;
using SocialMedia.Core.Entities;
using SocialMedia.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly SocialMediaContext _context;
        public PostRepository(SocialMediaContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Post>> GetPosts()
        {
            var posts = await _context.Posts.ToListAsync();
            return posts;
        }

        public async Task<Post> GetPost(int id)
        {
            var posts = await _context.Posts.FirstOrDefaultAsync(x => x.PostId == id);
            return posts;
        }

        public async Task InsertPost (Post post)
        {
            _context.Add(post);
            await _context.SaveChangesAsync();
        }
        
    }
}
