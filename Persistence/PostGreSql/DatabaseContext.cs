using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.PostGreSql
{
    /// <summary>
    /// Database for PostGreSql database
    /// </summary>
    internal class DatabaseContext : DbContext, IDatabaseContext
    {
        /// <summary>
        /// Datatable CarBrand.
        /// </summary>
        public DbSet<CarBrand> CarBrand { get; set; }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="options"></param>
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        internal bool Disposed;

        /// <summary>
        /// Prop. to know if the dbcontext is disposed
        /// </summary>
        /// <param name="isDisposing"></param>
        protected virtual void Dispose(bool isDisposing)
        {
            if (!Disposed)
            {
                if (isDisposing)
                {
                    base.Dispose();
                }
                Disposed = true;
            }
        }
        /// <summary>
        /// Override dispose
        /// </summary>
        public override void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~DatabaseContext()
        {
            Dispose(false);
        }

        /// <summary>
        /// Applying the configuration for my databasecontext.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
        }
    }
}
