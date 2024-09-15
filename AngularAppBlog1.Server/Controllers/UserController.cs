

using BUSINESS.Contracts;
using BUSINESS.Implemetations;
using DOMAIN.Dtos;
using Microsoft.AspNetCore.Mvc;
using SHARED.Dtos;
using static BUSINESS.Implemetations.UserBusinessEngine;

namespace UI.Controllers
{
    [Route("User")]
    public class UserController : ControllerBase
    {
        private readonly IUserBusinessEngine _userEngine;
        public UserController(IUserBusinessEngine userEngine)
        {
            _userEngine = userEngine;
        }
    

        [HttpGet("GetCities")]
        public List<CityDto> GetCities()
        {
            return this._userEngine.GetCities();
        }

        [HttpGet("GetDistricts")]
        public List<DistrictDto> GetDistricts(int cityId)
        {
            return this._userEngine.GetDistricts(cityId);
        }

        [HttpGet("GetCategories")]
        public List<CategoryDto> GetCategories()
        {
            return this._userEngine.GetCategories();
        }
        [HttpPost("AddIndictination")]
        public IndictinationDto AddIndictination([FromBody] IndictinationDto userIndictination)
        {
            return this._userEngine.AddIndictination(userIndictination);
        }
           
        [HttpGet("GetContactInfo")]
        public ContactDto GetContactInfo()
        {
            return this._userEngine.GetContactInfo();
        }
        [HttpPost("UpdateUserSettings")]
        public bool UpdateUserSettings(UserSettingsDto settings)
        {
            return this._userEngine.UpdateUserSettings(settings);  
        }
        [HttpGet("GetTeamMembers")]
        public List<Team_MemberDto> GetTeamMembers()
        {
            return this._userEngine.GetTeamMembers();
        }
  
    }
}
