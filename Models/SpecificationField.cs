using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.Models
{
    public class SpecificationField
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Specification Specification { get; set; }
    }
}
