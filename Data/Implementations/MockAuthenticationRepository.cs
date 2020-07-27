using e_commerce_cp.Data.Interfaces;
using e_commerce_cp.DataAccessLayer.Authentication;
using e_commerce_cp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.Data.Implementations
{
    public class MockAuthenticationRepository : IAuthenticationRepository
    {
        private ECommerceCPContext _context;

        public MockAuthenticationRepository(ECommerceCPContext context)
        {
            _context = context;
        }

        public User AuthenticateUser(User user)
        {
            var userFromContext = _context.Users.FirstOrDefault(u => u.Email == user.Email);

            //logic to check if the passwords matches...
            //basic if for now
            if (userFromContext.Password == user.Password)
                return userFromContext;

            return null;
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public User Save(User user)
        {
            var dal = new DALUser(_context); // the dal is redundant here, probably get rid of them at this point
            return dal.Save(user);
        }
    }
}
