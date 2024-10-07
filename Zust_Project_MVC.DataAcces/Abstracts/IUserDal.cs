using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust_Project_MVC.Coree.DataAccess;
using Zust_Project_MVC.Entity.Entities;

namespace Zust_Project_MVC.DataAcces.Abstracts
{
    public interface IUserDal :IEFEntityRepository<CustomIdentityUser>
    {
        Task<CustomIdentityUser> GetByIdAsync(string userId);
    }
}
