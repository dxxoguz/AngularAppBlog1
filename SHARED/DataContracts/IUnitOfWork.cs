using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARED.DataContracts
{
    public interface IUnitOfWork : IDisposable
    {
        ICommentRepository comments { get; }
        IUserRepository users { get; }
        IBlogPostRepository topics { get; }
        ICityRepository cities { get; }
        IDistrictRepository districts { get; }
        ICatgeoryRepository categories { get; }
        IIndictinationRepository indictination { get; }
        IContactInfoRepository contactInfo { get; }
        ILoginRepository loginUser { get; }
        IUserNameRepository userName { get; }
        IUserSettingsRepository userSettings { get; }
        IAboutUsRepository aboutUs { get; }
        ITeamMemberRepository teamMember { get; }   
        public void Save() { }
    }
}
