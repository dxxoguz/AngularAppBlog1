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
    public class IndictinationRepository : Repository<IndictinationDto>, IIndictinationRepository
    {
        private readonly BlogAppDbContext _db;
        public IndictinationRepository(BlogAppDbContext db) : base(db)
        {
            _db = db;
        }
    }

}
