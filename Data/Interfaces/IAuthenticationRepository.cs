using e_commerce_cp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.Data.Interfaces
{
    public interface IAuthenticationRepository
    {
        User GetUser(int id);
        User Save(User user);
        User AuthenticateUser(User user);
    }
}
