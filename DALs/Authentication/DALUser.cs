using e_commerce_cp.Data;
using e_commerce_cp.Models;
using e_commerce_cp.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace e_commerce_cp.DataAccessLayer.Authentication
{
    public class DALUser
    {
        private ECommerceCPContext _context;

        public DALUser(ECommerceCPContext context)
        {
            _context = context;
        }

        public User Save(User user)
        {
                var userToReturn = _context.Users.Add(user);
                _context.SaveChanges();

                return userToReturn.Entity;
        }
    }
}
