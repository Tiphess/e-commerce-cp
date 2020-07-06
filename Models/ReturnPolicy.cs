using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.Models
{
    public class ReturnPolicy
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public int ReturnForRefundWithinDays { get; set; }
        public int ReturnForReplacementWithinDays { get; set; }

    }
}
