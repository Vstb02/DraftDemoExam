using Draft.Persistence;
using Draft.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.WPF.HostBuilders
{
    public static class AddDbContextHostBuilderExtensions
    {
        public static IHostBuilder AddDbContext(this IHostBuilder host)
        {
            host.ConfigureServices((context, services) =>
            {
                string connectionString = context.Configuration.GetConnectionString("DefaultConnection");
                Action<DbContextOptionsBuilder> configureDbContext = o => o.UseSqlServer(connectionString);

                services.AddDbContext<ApplicationDbContext>(configureDbContext);
                services.AddSingleton<ApplicationDbContextFactory>(new ApplicationDbContextFactory(configureDbContext));
            });

            return host;
        }
    }
}
