using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust_Project_MVC.Coree.Repostory;
using Zust_Project_MVC.DataAcces.Abstracts;
using Zust_Project_MVC.Entity.Data;
using Zust_Project_MVC.Entity.Entities;

namespace Zust_Project_MVC.DataAcces.Concrete
{
    public class UserDal : EFEntityRepository<CustomIdentityUser,ZustDbContext>,IUserDal
    {
        private readonly ZustDbContext _context;
        public UserDal(ZustDbContext context):base(context) 
        {
            _context = context;
        }

        public async Task<CustomIdentityUser> GetByIdAsync(string userId)
        {
            return await _context.Users.FindAsync(userId);
        }
    }
}
