using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zust_Project_MVC.Entity.Entities
{
	public class Comment
	{

        public int  Id { get; set; }
        public string? Text { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;

        public string? UserId { get; set; }
        public virtual CustomIdentityUser User { get; set; }

        public int PostId { get; set; }
       

    }
}
