using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public User User { get; set; }
        public IList<ItemCart> ItemCarts { get; set; }
    }
}
