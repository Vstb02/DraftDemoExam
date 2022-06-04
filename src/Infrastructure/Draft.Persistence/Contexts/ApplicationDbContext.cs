using Draft.Application.Common.Interfaces;
using Draft.Domain.Entites;
using Draft.Persistence.Configuration;
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

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MaterialConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());
            modelBuilder.ApplyConfiguration(new TypeSupplierConfiguration());
            modelBuilder.ApplyConfiguration(new TypeMaterialConfiguration());
            modelBuilder.ApplyConfiguration(new UnitConfiguration());
            modelBuilder.ApplyConfiguration(new StorageConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
