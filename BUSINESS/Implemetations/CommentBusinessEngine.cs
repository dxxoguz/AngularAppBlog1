using BUSINESS.Contracts;
using DOMAIN.Dtos;
using SHARED.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BUSINESS.Implemetations
{
    public class CommentBusinessEngine:ICommentBusinessEngine
    {
        private readonly IUnitOfWork _uow;
            public CommentBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow; 
        }

        public CommentDto AddComment(CommentDto comment)
        {

            CommentDto commentModel = new CommentDto();
            commentModel.UserId = comment.UserId;
            commentModel.Title = comment.Title;
            commentModel.Content = comment.Content; 
            commentModel.Date=DateTime.Now;
            _uow.comments.Add(commentModel);
            _uow.Save();
            return commentModel;
        }

        public bool DeleteComment(int commentId)
        {
            var updatedModel = this._uow.comments.GetById(commentId);
            if (updatedModel != null)
            {
                updatedModel.isRemoved = true;
                _uow.Save();
            }
            return true;
        }

        public List<CommentDto> GetComments(int pageNumber, int count)
        {
            List<CommentDto> commentList = new List<CommentDto>();
           var commentData = this._uow.comments.GetAll();
            if (commentData != null)
            {
                foreach (var comment in commentData) {

                    commentList.Add(new CommentDto()
                    {
                        Content=comment.Content,
                        Title=comment.Title,  
                       Date= DateTime.Now,
                       
                       
                    });
                    
                }
            }
            return commentList;
        }

        public CommentDto UpdateComment(CommentDto comment)
        {
            var updatedModel = this._uow.comments.GetById(comment.Id);
            if (updatedModel != null) {
                updatedModel.UserId = comment.UserId;
                updatedModel.Title = comment.Title;
                updatedModel.Content = comment.Content;
                _uow.comments.Add(updatedModel);
                _uow.Save();
            

            }
            return updatedModel!;
        }
    }
}
