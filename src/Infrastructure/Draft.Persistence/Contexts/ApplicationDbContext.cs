using Draft.Application.Common.Interfaces;
using Draft.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Material> Materials { get; set; } = null!;
        public DbSet<Supplier> Suppliers { get; set; } = null!;
        public DbSet<Storage> Storages { get; set; } = null!;
        public DbSet<TypeMaterial> TypeMaterials { get; set; } = null!;
        public DbSet<TypeSupplier> TypeSupplier { get; set; } = null!;
        public DbSet<Unit> Units { get; set; } = null!;

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
