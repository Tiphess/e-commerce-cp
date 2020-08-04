using e_commerce_cp.Data.Interfaces;
using e_commerce_cp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Konscious.Security.Cryptography;
using e_commerce_cp.Utils;

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

            if (PasswordUtils.Verify(userFromContext.Password, user.Password))
                return userFromContext;

            return null;
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public User Save(User user)
        {
            user.Password = PasswordUtils.Hash(user.Password);

            var userToReturn = _context.Users.Add(user);
            _context.SaveChanges();

            return userToReturn.Entity;
        }
    }
}
