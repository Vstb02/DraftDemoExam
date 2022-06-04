using Draft.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Material> Materials { get; set; }
        DbSet<Supplier> Suppliers { get; set; }
        DbSet<Storage> Storages { get; set; }
        DbSet<TypeMaterial> TypeMaterials { get; set; }
        DbSet<TypeSupplier> TypeSupplier { get; set; }
        DbSet<Unit> Units { get; set; }

        Task<int> SaveChangesAsync();
    }
}
