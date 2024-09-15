using BUSINESS.Contracts;
using DOMAIN.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using SHARED.DataContracts;
using SHARED.Dtos;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
//token kontrol/ account tasarımlar,add post form,ana sayfa dinamik tasarım
namespace BUSINESS.Implemetations
{

    public class AuthBusinessEngine:IAuthBusinessEngine
    {
        private readonly IUnitOfWork _uow;
        public AuthBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }

        private const string SecretKey = "buçokgizlibirşifreanahtarıdırbilginizolsun";
        private const int TokenExprationMinutes = 30;
        public static string GenerateToken(string userName)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name,userName)
                }),
                //Expires = DateTime.UtcNow.AddMinutes(TokenExprationMinutes),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);


        }
        public AddingUserMessage AddUser(UserDto user)
        {
            var loginData = this._uow.loginUser.GetAll().ToList();
            UserDto userModel = new UserDto();
            try
            {
                if (user != null)
                {

                    foreach (var logModel in loginData)
                    {
                        if (user.UserName != logModel.UserName && user.UserEmail != logModel.Email)
                        {
                            LoginDto loginUserModel = new LoginDto();
                            UserNameDto userNameModel = new UserNameDto();
                            this._uow.loginUser.Add(loginUserModel);
                            loginUserModel.Email = user.UserEmail;
                            loginUserModel.Id= user.Id;
                            loginUserModel.UserName = user.UserName;
                            loginUserModel.Password = user.Password;
                            userModel.FirstName = user.FirstName;
                            userModel.LastName = user.LastName;
                            userModel.UserEmail = user.UserEmail;
                            userModel.UserName = user.UserName;
                            userModel.DateOfBirth = user.DateOfBirth;
                            userModel.Password = user.Password;
                            userModel.Gender = user.Gender;
                            userModel.City = user.City;
                            userModel.Adding = DateTime.Now;
                            userModel.District = user.District;
                            userModel.Customer_Inform = user.Customer_Inform;
                            userModel.Customer_Allow = user.Customer_Allow;
                            userNameModel.UserName = user.UserName;
                            this._uow.users.Add(userModel);
                            this._uow.loginUser.Add(loginUserModel);
                            this._uow.userName.Add(userNameModel);
                        }

                    }

                    this._uow.Save();

                }
                else
                {
                    return new AddingUserMessage { message = "Please Login", UserModel = userModel };
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return new AddingUserMessage { message = "Successful", UserModel = userModel };
        }
        public class AddingUserMessage
        {
            public string message = "";
            public UserDto UserModel = new UserDto();

        }
        public LoginUser Login(LoginDto loggedUser)

        {
            UserDto userModel = new UserDto();
            var resToken = "test";

            bool isValidUser = ValidateUser(loggedUser.Email, loggedUser.Password);
            if (!isValidUser)
            {
                resToken = "UnAthorized Login Acception";
        
            }
            else
            {
                string userName = "";
                var userData = this._uow.users.GetAll(u => u.UserEmail == loggedUser.Email).OrderBy(e => loggedUser.Email).LastOrDefault();
                userModel.Password = userData.Password;
                userModel.Customer_Inform=userData.Customer_Inform;
                userModel.FirstName = userData.FirstName;
                userModel.UserName = userData.UserName;
                userModel.LastName = userData.LastName;
                userModel.Adding = userData.Adding;
                userModel.Customer_Inform = userData.Customer_Inform;
                userModel.City = userData.City;
                userModel.District = userData.District;    
                
                int atIndex = loggedUser.Email.IndexOf("@");
                if(atIndex >= 0)
                {
                   userName=  loggedUser.Email.Substring(0, atIndex);
                }

                var token = GenerateToken(userName);
                resToken = token;


            }

            return new LoginUser { loggedUser = userModel,token = resToken};
        }
        public class LoginUser
        {
            public UserDto loggedUser = new UserDto();
            public string token = "";

        }
        public bool ValidateUser(string email, string password)
        {
            bool res = false;
            try
            {
                var user = this._uow.users.GetAll(u => u.UserEmail == email).OrderBy(e=>email).LastOrDefault();
                if (user != null)
                {
                    if (user.Password == password)
                    {
                        res = true;
                    }
                }
                res = true;
                return res;
            }
            catch (Exception)
            {

                res = false;
            }
            return res;
        }
        public string SecureEndPoint(HttpContext httpContext)
        {
            string token = httpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var principal = TokenValidation.GetPrincipalFromToken(token);

            if (principal == null)
            {
                return "Error";
            }

            return "Secure data";
        }
    }
}
