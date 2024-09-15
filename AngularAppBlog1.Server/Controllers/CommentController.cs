

using BUSINESS.Contracts;
using DOMAIN.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    [Route("Comment")]
    public class CommentController : Controller
    {
        private readonly ICommentBusinessEngine _commentEngine;
        public CommentController(ICommentBusinessEngine commentEngine)
        {
            _commentEngine = commentEngine;
        }
        [HttpPost("AddComment")]
        public CommentDto AddComment(CommentDto comment)
        {
            return this._commentEngine.AddComment(comment);
        }
        [HttpGet("GetComments")]
        public List<CommentDto> GetComments(int pageNumber,int count )
        {
            return this._commentEngine.GetComments(pageNumber,count);
        }

    }
}
