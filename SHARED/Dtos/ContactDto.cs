using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARED.Dtos
{
    public class ContactDto
    {
        public int Id { get; set; } 
        public string? Address { get; set; }
        public string? Address2 { get; set; }
        public int Phone { get; set; }
        public string? Email { get; set; }
    }
}
