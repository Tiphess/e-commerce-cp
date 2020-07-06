using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.Models
{
    public class Specification
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<SpecificationField> Categories { get; set; }
        public Detail Detail { get; set; }
    }
}
