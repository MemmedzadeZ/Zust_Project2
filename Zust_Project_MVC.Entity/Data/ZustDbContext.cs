using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust_Project_MVC.Entity.Entities;

namespace Zust_Project_MVC.Entity.Data
{
    public class ZustDbContext: IdentityDbContext<CustomIdentityUser, CustomIdentityRole, string>
    {
        public ZustDbContext()
        {
            
        }
        public ZustDbContext(DbContextOptions<ZustDbContext> options)
            :base(options) { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Likes> Likes { get; set; }
        
    }
}
