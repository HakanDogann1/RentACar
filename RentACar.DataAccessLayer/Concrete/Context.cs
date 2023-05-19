using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentACar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccessLayer.Concrete
{
	public class Context:IdentityDbContext<AppUser,AppRole,int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-NOMRM5V\\SQLEXPRESS;initial catalog=DbCarRental;integrated security=true;");
		}

        public DbSet<AboutUs> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<BlogWithTagCloud> BlogWithTagClouds { get; set; }
        public DbSet<ContactMe> ContactMes { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Reserve> Reserves { get; set; }
        public DbSet<ReserveService> ReserveServices { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
    }
}
