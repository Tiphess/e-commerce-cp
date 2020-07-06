using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime ExpectedArrival { get; set; }
        public User User { get; set; }
        public IList<ItemOrder> ItemOrders { get; set; }
    }
}
