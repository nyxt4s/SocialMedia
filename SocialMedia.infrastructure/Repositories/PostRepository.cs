using SocialMedia.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Repositories
{
    public class PostRepository
    {
        public IEnumerable<Post> GetPosts()
        {
            var posts = Enumerable.Range(1, 10).Select(x => new Post
            {
                PostId = x,
                Description = "Descripcion",
                Date = DateTime.Now,
                Image = $"https://miapis.com{x}",
                UserID = x * 2
            });

            return posts;
        }
    }
}
