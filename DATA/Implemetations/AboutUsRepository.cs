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
    public class AboutUsRepository : Repository<AboutUsDto>, IAboutUsRepository
    {
        private readonly BlogAppDbContext _db;
        public AboutUsRepository(BlogAppDbContext db) : base(db) {

            _db = db;
        }
    }
}
