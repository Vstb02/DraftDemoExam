using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.Domain.Entites
{
    public class Material : BaseEntity
    {
        public string Name { get; set; }
        public TypeMaterial TypeMaterial { get; set; }
        public int TypeMaterialId { get; set; }
        public double Cost { get; set; }
        public int Count { get; set; }
        public int MinCount { get; set; }
        public int CountInPack { get; set; }
        public Unit Unit { get; set; }
        public int UnitId { get; set; }
    }
}
