using DOMAIN.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARED.Dtos
{
    public class UserSettingsDto
    {
        public int Id { get; set; } 
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? ProfilePic { get; set; }
        public string? UserMail { get; set; }
        public Boolean Customer_Inform { get; set; }
        public Boolean Customer_Allow { get; set; }
        public int UserId { get; set; }
        public virtual UserDto?  User { get; set; }
    }
}

