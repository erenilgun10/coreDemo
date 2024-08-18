using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //lp
            optionsBuilder.UseSqlServer("server=DESKTOP-51TNQ4H;database=CoreBlogDb; integrated security=true;TrustServercertificate=true;");
            //Bpc
         // optionsBuilder.UseSqlServer("server=DESKTOP-FKCBKLL;database=CoreBlogDb; integrated security=true;TrustServercertificate=true;");

        }

        public DbSet<About> Abouts {  get; set; } 
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }


    }
}
