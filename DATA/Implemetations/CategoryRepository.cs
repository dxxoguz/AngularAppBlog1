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
    public class CategoryRepository : Repository<CategoryDto>, ICatgeoryRepository
    {
        private readonly BlogAppDbContext _db;
        public CategoryRepository(BlogAppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
