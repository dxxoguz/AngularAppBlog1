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
    public class UserRepository : Repository<UserDto>, IUserRepository
    {
        private readonly BlogAppDbContext _db;
        public UserRepository(BlogAppDbContext db) : base(db)
        {
            _db = db;
        }
    }

}