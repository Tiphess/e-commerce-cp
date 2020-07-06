using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.Models
{
    public class Distributor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string WebsiteUrl { get; set; }
        public string WebsiteProductPageUrl { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
