using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust_Project_MVC.Coree.DataAccess;

namespace Zust_Project_MVC.Entity.Entities
{
    public class CustomIdentityRole : IdentityRole,IEntity  
    {
    }
}
