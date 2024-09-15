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
    public class TeamMemberRepository : Repository<Team_MemberDto>, ITeamMemberRepository
    {
        private readonly BlogAppDbContext _db;
        public TeamMemberRepository(BlogAppDbContext db) : base(db)
        {
            _db = db;
        }
    }

}
