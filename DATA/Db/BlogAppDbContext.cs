using DOMAIN.Dtos;
using Microsoft.EntityFrameworkCore;
using SHARED.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Db
{
    public class BlogAppDbContext : DbContext
    {
        public DbSet<CommentDto> Comments { get; set; }
        public DbSet<UserDto> Users { get; set; }
        public DbSet<UserNameDto> UserNames { get; set; }
        public DbSet<CategoryDto> Categories { get; set; }
        public DbSet<BlogPostDto> BlogPost { get; set; }
        public DbSet<ContactDto> ContactInfo { get; set; }
        public DbSet<CityDto> City { get; set; }
        public DbSet<DistrictDto> District { get; set; }
        public DbSet<IndictinationDto>  Indictination { get; set; }
        public DbSet<LoginDto> LoginUser { get; set; }
        public DbSet<UserSettingsDto> UserSettings { get; set; }
        public DbSet<AboutUsDto> AboutUs { get; set; }
        public DbSet<Team_MemberDto> TeamMember { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BlogApp;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}