using Microsoft.AspNetCore.Mvc;
using SocialMedia.core.Interfaces;
using SocialMedia.Infrastructure.Repositories;
using System.Threading.Tasks;

namespace SocialMedia.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        public PostController(IPostRepository postRepository) {
            _postRepository = postRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetPost()
        {
            var posts = await _postRepository.GetPosts();
            return Ok(posts);
        }
    }
}
