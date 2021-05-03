
using SocialMedia.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMedia.core.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Publicacion>> GetPosts();
    }
}
