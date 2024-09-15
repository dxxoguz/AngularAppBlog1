using SHARED.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Contracts
{
    public interface ITopicBusinessEngine
    {
        public List<BlogPostDto> GetPosts(int pageNumber, int perPage, int categoryId = 0);
        public BlogPostDto AddBlogPost(BlogPostDto blogPost);
        public BlogPostDto GetRandomPost();
    }
}
