using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zust_Project_MVC.Entity.Entities
{
	public class Likes
	{
		public int Id { get; set; }

		public string? UserId { get; set; }
		public virtual CustomIdentityUser? User { get; set; }

		public int PostId { get; set; }
		public virtual Post? Post { get; set; }
	}
}
