using DOMAIN.Dtos;
using SHARED.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BUSINESS.Implemetations.UserBusinessEngine;

namespace BUSINESS.Contracts
{
    public interface IUserBusinessEngine
    {

        public List<CityDto> GetCities();
        public List<DistrictDto> GetDistricts(int cityId);
        public List<CategoryDto> GetCategories();
        public IndictinationDto AddIndictination(IndictinationDto userIndictination);
        public ContactDto GetContactInfo();
        public bool UpdateUserSettings(UserSettingsDto settings);
        public List<Team_MemberDto> GetTeamMembers();
        //public UserDto GetUser(int userId);

    }


}
