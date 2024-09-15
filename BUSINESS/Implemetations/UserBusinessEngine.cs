using BUSINESS.Contracts;
using DOMAIN.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using SHARED.DataContracts;
using SHARED.Dtos;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Implemetations
{
    public class UserBusinessEngine : IUserBusinessEngine
    {
        private readonly IUnitOfWork _uow;
        public UserBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }

        //AUTH
        public List<CityDto> GetCities()
        {
            List<CityDto> cities = new List<CityDto>();
            var cityData = this._uow.cities.GetAll().ToList();
            if (cityData != null)
            {
                foreach (var city in cityData)
                {
                    cities.Add(new CityDto()
                    {
                        Id = city.Id,
                        CityName = city.CityName,
                    });
                }
            }
            return cities;

        }
        public List<DistrictDto> GetDistricts(int cityId)
        {
            List<DistrictDto> districts = new List<DistrictDto>();
            var districtData = _uow.districts.GetAll(d => d.CityId == cityId).ToList();
            if (districtData != null)
            {
                foreach (var district in districtData)
                {
                    districts.Add(new DistrictDto()
                    {
                        DistrictName = district.DistrictName,
                        Id = district.Id,
                        CityId = cityId

                    });
                }
            }
            return districts;

        }

        //public UserDto GetUser(int userId)
        //{
        //    UserDto userModel = new UserDto();
        //    var userData = this._uow.users.GetById(userId);
        //    userModel.FirstName = userData.FirstName;
        //    userModel.UserName = userData.UserName;
        //    userModel.LastName = userData.LastName;
        //    userModel.Adding = userData.Adding;
        //    userModel.Customer_Inform = userData.Customer_Inform;
        //    userModel.City = userData.City;
        //    userModel.District = userData.District;
        //    userModel.IsActive = userData.IsActive;
        //    return userModel;
        //}

        public List<CategoryDto> GetCategories()
        {
            List<CategoryDto> categories = new List<CategoryDto>();
            var categoryData = _uow.categories.GetAll().ToList();
            if (categoryData != null)
            {
                foreach (var cat in categoryData)
                {
                    categories.Add(new CategoryDto()
                    {
                        Id = cat.Id,
                        Name = cat.Name,
                    });
                }
            }
            return categories;

        }
        public IndictinationDto AddIndictination(IndictinationDto userIndictination)
        {
            IndictinationDto IndictinationModel = new IndictinationDto();
            if (userIndictination != null)
            {
                IndictinationModel.Content = userIndictination.Content;
                IndictinationModel.Title = userIndictination.Title;
                IndictinationModel.AddingDate = DateTime.Now;
                _uow.indictination.Add(IndictinationModel);
                _uow.Save();
            }
            return IndictinationModel;
        }
        public ContactDto GetContactInfo()
        {
            ContactDto contactModel = new ContactDto();
            var contactData = _uow.contactInfo.GetAll().ToList();
            if (contactData != null)
            {
                contactModel.Address = contactData[0].Address;
                contactModel.Address2 = contactData[0].Address2;
                contactModel.Phone = contactData[0].Phone;
                contactModel.Email = contactData[0].Email;

            }
            return contactModel;

        }
        public bool UpdateUserSettings(UserSettingsDto settings)
        {
            var updatedUser = this._uow.users.GetById(settings.UserId);
            if (updatedUser != null)
            {
                updatedUser.UserName = settings.UserName;
                updatedUser.UserEmail = settings.UserMail;
                updatedUser.Password = settings.Password;
                updatedUser.ProfilePic = settings.ProfilePic;
                updatedUser.IsActive = settings.IsActive;

            }
            return true;

        }
        public List<Team_MemberDto> GetTeamMembers()
        {
            List<Team_MemberDto> teamMembers = new List<Team_MemberDto>();
            var data = this._uow.teamMember.GetAll().ToList();
            if (data != null)
            {
                foreach (var mem in data)
                {
                    teamMembers.Add(new Team_MemberDto()
                    {
                        Department = mem.Department,
                        Id = mem.Id,
                        Name = mem.Name,
                        Title = mem.Title,

                    });

                }

            }
            return teamMembers;
        }

    }
}



























