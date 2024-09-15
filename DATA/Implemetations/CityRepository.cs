using DATA.Db;
using SHARED.DataContracts;
using SHARED.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Implemetations
{
    public class CityRepository : Repository<CityDto>, ICityRepository
    {
        private readonly BlogAppDbContext _db;
        public CityRepository(BlogAppDbContext db) : base(db) {

            _db = db;
        }
    }
}
