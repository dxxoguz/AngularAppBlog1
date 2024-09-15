using DATA.Db;
using DOMAIN.Dtos;
using SHARED.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Implemetations
{
    public class UserNameRepository : Repository<UserNameDto>, IUserNameRepository
    {
        private readonly BlogAppDbContext _db;
        public UserNameRepository(BlogAppDbContext db) : base(db)
        {
            _db = db;
        }
    }

}