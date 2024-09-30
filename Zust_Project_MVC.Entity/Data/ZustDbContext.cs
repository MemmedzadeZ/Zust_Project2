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

        public ZustDbContext(DbContextOptions<ZustDbContext> options)
            :base(options) { }
        
    }
}
