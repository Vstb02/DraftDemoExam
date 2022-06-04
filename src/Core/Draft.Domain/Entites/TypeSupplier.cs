using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.Domain.Entites
{
    public class TypeSupplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Supplier> Suppliers { get; set; }
    }
}
