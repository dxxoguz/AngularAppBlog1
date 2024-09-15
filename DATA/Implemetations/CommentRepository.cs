using DATA.Db;
using DOMAIN.Dtos;
using SHARED.DataContracts;
using SHARED.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Implemetations
{
    public class CommentRepository : Repository<CommentDto>, ICommentRepository
    {
        private readonly BlogAppDbContext _db;
        public CommentRepository(BlogAppDbContext db) : base(db)
        {
            _db = db;
        }
    }

}