using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust_Project_MVC.Buisnes.Abstract;

namespace Zust_Project_MVC.Buisnes.Concrete
{
    public class ImageServices:IImageService
    {
		
		public async Task<string> SaveFileAsync(IFormFile file)
		{
			if (file != null && file.Length > 0)
			{
				var fileName = Path.GetFileNameWithoutExtension(file.FileName) + "_" + Guid.NewGuid() + Path.GetExtension(file.FileName);

				var fileDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "images", "user");

				if (!Directory.Exists(fileDirectory))
				{
					Directory.CreateDirectory(fileDirectory);
				}

				var filePath = Path.Combine(fileDirectory, fileName);

				using (var stream = new FileStream(filePath, FileMode.Create))
				{
					await file.CopyToAsync(stream);
				}

				return "~/Models/wwwroot/assets/images/user/" + fileName;
			}

			return null;
		}

	}
}
