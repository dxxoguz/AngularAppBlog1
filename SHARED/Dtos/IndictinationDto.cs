using DOMAIN.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARED.Dtos
{
    public class IndictinationDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime AddingDate { get; set; }
        public string? Content { get; set; }
        public int UserId { get; set; }
    }
}
