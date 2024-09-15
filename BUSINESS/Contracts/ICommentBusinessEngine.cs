using DOMAIN.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Contracts
{
    public interface ICommentBusinessEngine
    {
        public CommentDto AddComment(CommentDto comment);
        public List<CommentDto> GetComments(int pageNumber, int count);
        public bool DeleteComment(int commentId);
        public CommentDto UpdateComment(CommentDto comment);

    }
}
