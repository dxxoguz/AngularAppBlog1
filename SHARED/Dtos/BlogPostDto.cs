using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARED.Dtos
{
    public class BlogPostDto
    {
        public int Id { get; set; } 
        public string? Title { get; set; }
        public string? Author { get; set; }
        public DateTime? Adding { get; set; }
        public string? Content { get; set; }
        public int CategoryId { get; set; }
    }
}
