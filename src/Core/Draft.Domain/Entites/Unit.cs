using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.Domain.Entites
{
    public class Unit : BaseEntity
    {
        public string Name { get; set; }
        public List<Material> Materials { get; set; }
    }
}
