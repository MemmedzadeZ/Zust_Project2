
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust_Project_MVC.Entities.Enitities;

namespace Zust_Project_MVC.Entities.Data
{
    public class ZustNetworkDbContext : IdentityDbContext<CustomIdentityUser, CustomIdentityRole, string>
    {
   
        public ZustNetworkDbContext(DbContextOptions<ZustNetworkDbContext> options) 
            : base(options)
        {
        }
    }
}
   
