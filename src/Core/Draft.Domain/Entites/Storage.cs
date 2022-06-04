using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.Domain.Entites
{
    public class Storage
    {
        public int Id { get; set; }
        public List<Material> Materials { get; set; }
        public List<Supplier> Suppliers { get; set; }
    }
}
