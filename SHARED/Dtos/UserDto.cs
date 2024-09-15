using SHARED.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string? Gender { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Password { get; set; }
        public string? UserEmail { get; set; }
        public bool? IsActive { get; set; } = true;
        public string? ProfilePic { get; set; } = null;
        public string? City { get; set; }
        public DateTime? Adding { get; set; }
        public string? District { get; set; }
        public Boolean Customer_Inform { get; set; }
        public Boolean Customer_Allow { get; set; }
        public List<IndictinationDto>? Indictinations { get; set; }


    }
}



