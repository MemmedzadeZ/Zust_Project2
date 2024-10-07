using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust_Project_MVC.Coree.DataAccess;

namespace Zust_Project_MVC.Entity.Entities
{
    public class CustomIdentityUser : IdentityUser, IEntity
    {
        public string? ImageUrl { get; set; }
        public bool IsOnline { get; set; }
        public DateTime DisconnectTime { get; set; } = DateTime.Now;
		public string ConnectTime { get; set; } = "";

		// ConnectTime stringdən DateTime-ə çevrilməsi
		//private string _connectTime;
		//public string ConnectTime
		//{
		//    get => _connectTime;
		//    set
		//    {
		//        DateTime parsedDate;
		//        if (DateTime.TryParse(value, out parsedDate))
		//        {
		//            _connectTime = parsedDate.ToString();  // Və ya parse edilmiş DateTime-i yadda saxlamaq üçün
		//        }
		//        else
		//        {
		//            // Default bir DateTime və ya error handle
		//            _connectTime = DateTime.Now.ToString(); // Problemi idarə etmək üçün indiki zamanı təyin edin.
		//        }
		//    }
		//}
	}


}
