using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.Domain.Entites
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TypeSupplier TypeSupplier { get; set; }
        public int TypeSupplierId { get; set; }
        public string INN { get; set; }
        public int Raiting { get; set; }
        public DateTime Date { get; set; }
        public Storage Storage { get; set; }
        public int StorageId { get; set; }
    }
}
