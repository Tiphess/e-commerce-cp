using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.Models
{
    public class ItemCart
    {
        public string ItemId { get; set; }
        public string CartId { get; set; }
        public Item Item { get; set; }
        public Cart Cart { get; set; }
    }
}
