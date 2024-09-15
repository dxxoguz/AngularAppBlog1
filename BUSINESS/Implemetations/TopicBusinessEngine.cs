using BUSINESS.Contracts;
using SHARED.DataContracts;
using SHARED.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Implemetations
{
    public class TopicBusinessEngine : ITopicBusinessEngine
    {
        private readonly IUnitOfWork _uow;
        public TopicBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public BlogPostDto AddBlogPost(BlogPostDto blogPost)
        {
            BlogPostDto blogPostModel = new BlogPostDto();
            try
            {

                blogPostModel.Author = blogPost.Author;
                blogPostModel.Content = blogPost.Content; ;
                blogPostModel.Title = blogPost.Title;
                blogPostModel.Adding = DateTime.Now;
                blogPostModel.CategoryId = blogPost.CategoryId;

                _uow.topics.Add(blogPostModel);
                _uow.Save();
                return blogPostModel;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public List<BlogPostDto> GetPosts(int pageNumber, int perPage, int categoryId = 0)
        {

            var index = (pageNumber * perPage) - perPage;
            if (index < 0) index = 0;
            List<BlogPostDto> postList = new List<BlogPostDto>();
            var postData = this._uow.topics.GetAll(p => categoryId == 0 || p.CategoryId == categoryId).Skip(index).Take(perPage).OrderBy(d => d.Adding).Reverse().ToList();
            if (postData != null)
            {
                foreach (var post in postData)
                {
                    postList.Add(new BlogPostDto()
                    {
                        Id = post.Id,
                        Author = post.Author,
                        CategoryId = post.CategoryId,
                        Content = post.Content,
                        Title = post.Title,
                        Adding = post.Adding

                    });
                }
            }
            return postList;

        }
        public BlogPostDto GetRandomPost()
        {
            BlogPostDto randBlogPost= new BlogPostDto();

            var blogDataCount = this._uow.topics.GetAll().ToList().Count();
            if (blogDataCount <= 0)
            {
                throw new ArgumentException("Count must be greater than 0", nameof(blogDataCount));
            }
            var blogPost = this._uow.topics.GetAll().OrderBy(i => Guid.NewGuid()).FirstOrDefault();
            randBlogPost.Adding = blogPost.Adding;
            randBlogPost.Id = blogPost.Id;
            randBlogPost.Author = blogPost.Author;
            randBlogPost.CategoryId = blogPost.CategoryId;
            randBlogPost.Content = blogPost.Content;
            randBlogPost.Title = blogPost.Title;

            return randBlogPost;
        }
    }



}







