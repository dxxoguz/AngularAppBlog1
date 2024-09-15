using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARED.Dtos
{
    public class Team_MemberDto
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public string?  Department { get; set; }
        public string? Title { get; set; }
            
    }
}
