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
    public class ContactInfoRepository : Repository<ContactDto>, IContactInfoRepository
    {
        private readonly BlogAppDbContext _db;
        public ContactInfoRepository(BlogAppDbContext db) : base(db)
        {
            _db = db;
        }
    }

}
