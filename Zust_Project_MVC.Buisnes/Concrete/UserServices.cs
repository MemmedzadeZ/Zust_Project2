using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Zust_Project_MVC.Buisnes.Abstract;
using Zust_Project_MVC.DataAcces.Abstracts;
using Zust_Project_MVC.Entity.Entities;

namespace Zust_Project_MVC.Buisnes.Concrete
{
    public class UserServices : IUserServices
    {
        private readonly IUserDal _userDal;

        public UserServices(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public async Task<CustomIdentityUser> GetUserByIdAsync(string userId)
        {
            return await _userDal.GetByIdAsync(userId);
        }

        //public async Task AddAsync(CustomIdentityUser entity)
        //{
        //    await _userDal.AddAsync(entity);
        //}

        //public async Task DeleteAsync(CustomIdentityUser entity)
        //{
        //   await _userDal.DeleteAsync(entity);
        //}

        //public async Task DeleteListAsync(List<CustomIdentityUser> entities)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<CustomIdentityUser> GetAsync(Expression<Func<CustomIdentityUser, bool>> filter)
        //{
        //    return await GetAsync(filter);
        //}

        //public Task<List<CustomIdentityUser>> GetListAsync(Expression<Func<CustomIdentityUser, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}


        //public async Task UpdateAsync(CustomIdentityUser entity)
        //{
        //    await UpdateAsync(entity);
        //}
    }
}
