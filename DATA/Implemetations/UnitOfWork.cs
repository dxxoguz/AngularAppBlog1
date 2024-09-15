using DATA.Db;
using SHARED.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Implemetations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogAppDbContext _db;
        public UnitOfWork(BlogAppDbContext db)
        {
            _db = db;
            comments = new CommentRepository(_db);
            users = new UserRepository(_db);
            topics = new BlogPostRepository(_db);
            cities = new CityRepository(_db);
            districts = new DistrictRepository(_db);
            categories = new CategoryRepository(_db);
            indictination = new IndictinationRepository(_db);
            contactInfo = new ContactInfoRepository(_db);
            loginUser = new LoginRepository(_db);
            userName = new UserNameRepository(_db);
            userSettings = new UserSettingsRepository(_db);
            aboutUs = new AboutUsRepository(_db);
            teamMember = new TeamMemberRepository(_db);



        }

        public ICommentRepository comments { get; private set; }

        public IUserRepository users { get; private set; }

        public IBlogPostRepository topics { get; private set; }

        public ICityRepository cities { get; private set; }

        public IDistrictRepository districts { get; private set; }
        public ICatgeoryRepository categories { get; private set; }

        public IIndictinationRepository indictination { get; private set; }
        public IContactInfoRepository contactInfo { get; private set; }

        public ILoginRepository loginUser { get; private set; }
        public IUserNameRepository userName { get; set; }
        public IUserSettingsRepository userSettings { get; }
        public IAboutUsRepository aboutUs { get; private set; }

        public ITeamMemberRepository teamMember { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
