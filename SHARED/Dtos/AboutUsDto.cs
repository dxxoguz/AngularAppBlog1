using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARED.Dtos
{
    public class AboutUsDto
    {
        public int Id { get; set; }
        public string? Mission_Vision { get; set; }
        public string? TeamLeader { get; set; }
        public string? Executive { get; set; }
        //public List<Team_MemberDto>? TeamMembers { get; set; }

    }
}
