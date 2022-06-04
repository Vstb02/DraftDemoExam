using Draft.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.Persistence
{
    public class ApplicationDbContextFactory
    {
        private readonly Action<DbContextOptionsBuilder> _configureDbContext;

        public ApplicationDbContextFactory(Action<DbContextOptionsBuilder> configureDbContext)
        {
            _configureDbContext = configureDbContext;
        }

        public ApplicationDbContext CreateDbContext()
        {
            DbContextOptionsBuilder<ApplicationDbContext> options = new DbContextOptionsBuilder<ApplicationDbContext>();

            _configureDbContext(options);

            return new ApplicationDbContext(options.Options);
        }
    }
}
