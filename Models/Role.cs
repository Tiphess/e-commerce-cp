using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<UserRole> UserRoles { get; set; }
    }
}
