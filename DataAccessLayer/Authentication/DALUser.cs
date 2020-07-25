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

        public DALUser()
        {
            _context = new ECommerceCPContext();
        }

        public User Save(User user)
        {
            using (var context = new ECommerceCPContext())
            {
                var userToReturn = context.Users.Add(user);
                context.SaveChanges();

                return userToReturn.Entity;
            }
        }
    }
}
