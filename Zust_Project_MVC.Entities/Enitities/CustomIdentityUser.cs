using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Zust_Project_MVC.Entities.Enitities
{
    public class CustomIdentityUser:IdentityUser
    {

        public string?  ImageUrl { get; set; }
        public bool IsOnline { get; set; }
        public DateTime DisconnectTime { get; set; }=DateTime.Now;
        public string? ConnectTime { get; set; } = "";

        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime Birthday { get; set; }



        public CustomIdentityUser()
        {
            Id = Guid.NewGuid().ToString();
        }

    }
}
