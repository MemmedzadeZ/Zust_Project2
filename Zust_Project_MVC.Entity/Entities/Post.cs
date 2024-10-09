using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zust_Project_MVC.Entity.Entities
{
	public class Post
	{

		public int Id { get; set; }
		public string? Text { get; set; }
		public string? VideoLink {  get; set; }
		public string? ImageUrl {  get; set; }
		public string? UserPubId { get; set; }

		public virtual CustomIdentityUser? UserPub {  get; set; }

		public virtual List<Comment>? Comments { get; set; }

		public virtual List<Likes> Likes { get; set; }

	}
}
