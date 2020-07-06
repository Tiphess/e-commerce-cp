using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.Models
{
    public class Detail
    {
        public int Id { get; set; }
        public ICollection<Specification> Specifications { get; set; }
        public Item Item { get; set; }
    }
}
