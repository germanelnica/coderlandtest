using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.PostGreSql;
using Persistence.PostGreSql.Repositories;

namespace Persistence
{
    public static class Startup
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, string connectionString)
        {
            // Para obtener más información sobre cómo configurar la aplicación, visite https://go.microsoft.com/fwlink/?LinkID=316888
            //var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING") ?? "";
            
            services.AddDbContext<DatabaseContext>(options =>
                options.UseNpgsql(connectionString)
            );
            services.AddScoped<IDatabaseContext>(provider => provider.GetService<DatabaseContext>());

            services.AddTransient(typeof(IRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;

        }
    }
}
