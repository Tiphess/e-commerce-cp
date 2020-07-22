using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int LimitPerCustomer { get; set; }
        public bool IsInStock { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public byte[] Image1 { get; set; }
        public byte[] Image2 { get; set; }
        public byte[] Image3 { get; set; }
        public Distributor Distributor { get; set; }
        public int DistributorId { get; set; }
        public Detail Details { get; set; }
        public int DetailsId { get; set; }
        public ReturnPolicy ReturnPolicy { get; set; }
        public int ReturnPolicyId { get; set; }
        public IList<ItemCart> ItemCarts { get; set; }
        public IList<ItemOrder> ItemOrders { get; set; }

    }
}
