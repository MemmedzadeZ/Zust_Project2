using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Zust_Project_MVC.Entity.Entities;

namespace Zust_Project_MVC.Buisnes.Abstract
{
    public interface IUserServices
    {
        //Task<CustomIdentityUser> GetAsync(Expression<Func<CustomIdentityUser, bool>> filter);
        //Task<List<CustomIdentityUser>> GetListAsync(Expression<Func<CustomIdentityUser, bool>> filter = null);
        //Task DeleteListAsync(List<CustomIdentityUser> entities);
        //Task DeleteAsync(CustomIdentityUser entity);
        //Task AddAsync(CustomIdentityUser entity);
        Task UpdateAsync(CustomIdentityUser entity);
        Task<CustomIdentityUser> GetUserByIdAsync(string userId);
    }
}
