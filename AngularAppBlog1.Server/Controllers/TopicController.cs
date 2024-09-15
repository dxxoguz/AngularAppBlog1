using BUSINESS.Contracts;
using BUSINESS.Implemetations;
using Microsoft.AspNetCore.Mvc;
using SHARED.Dtos;

namespace UI.Controllers
{
    [Route("Topic")]
    public class TopicController : Controller
    {
        private readonly ITopicBusinessEngine _topicEngine;
        public TopicController(ITopicBusinessEngine topicEngine)
        {
            _topicEngine = topicEngine;
        }
        [HttpGet("GetPosts")]
        public List<BlogPostDto> GetPosts(int pageNumber, int perPage, int categoryId = 0)
        {
            return this._topicEngine.GetPosts(pageNumber, perPage, categoryId);
        }

        [HttpPost("AddBlogPost")]
        public BlogPostDto AddBlogPost(BlogPostDto blogPost)
        {
            return this._topicEngine.AddBlogPost(blogPost);
        }
        [HttpGet("GetRandomPost")]
        public BlogPostDto GetRandomPost()
        {
            return this._topicEngine.GetRandomPost();
        }
    }
}
