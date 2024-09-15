using DOMAIN.Dtos;
using SHARED.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BUSINESS.Implemetations.AuthBusinessEngine;

namespace BUSINESS.Contracts
{
    public interface IAuthBusinessEngine
    {
       
        public AddingUserMessage AddUser(UserDto user);
        public LoginUser Login(LoginDto loggedUser);

    }
}
