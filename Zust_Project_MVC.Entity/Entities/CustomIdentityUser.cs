using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust_Project_MVC.Coree.DataAccess;

namespace Zust_Project_MVC.Entity.Entities
{
    public class CustomIdentityUser : IdentityUser,IEntity
    {

        public string? ImageUrl { get; set; }
        public bool IsOnline { get; set; }
        public DateTime DisconnectTime { get; set; } = DateTime.Now;
        public string? ConnectTime { get; set; } = "";
        public string? City { get; set; }
    }

}
