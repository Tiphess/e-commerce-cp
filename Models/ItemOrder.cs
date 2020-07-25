using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.Models
{
    public class ItemOrder
    {
        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
