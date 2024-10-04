using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Zust_Project_MVC.Buisnes.Abstract;
using Zust_Project_MVC.Entity.Entities;

namespace Zust_Project_MVC.Buisnes.Concrete
{
    public class UserServices : IUserServices
    {
        public Task AddAsync(CustomIdentityUser entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(CustomIdentityUser entity)
        {
            throw new NotImplementedException();
        }

        public Task<CustomIdentityUser> GetAsync(Expression<Func<CustomIdentityUser, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CustomIdentityUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
