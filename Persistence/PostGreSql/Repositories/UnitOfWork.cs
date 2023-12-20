using Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Persistence.PostGreSql.Repositories
{
    internal class UnitOfWork : IUnitOfWork
    {
        public ICarBrandRepository CarBrand { get; }
        private DatabaseContext _context;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
            CarBrand = new CardBrandRepository(_context);
        }
        public IUnitOfWork Create()
        {
            var connectionString = "User ID=germannunez;Password=Abc123;Server=postgres_image;Port=5432;Database=cardb;Pooling=true";// Environment.GetEnvironmentVariable("DB_CONNECTION_STRING") ?? "";

            if (_context.Disposed)
            {
                var contextOptions = new DbContextOptionsBuilder<DatabaseContext>()
                .UseNpgsql(connectionString)
                .Options;

                _context = new DatabaseContext(contextOptions);
            }
            return new UnitOfWork(_context);
        }
        /// <summary>
        /// Dispose database context.
        /// </summary>
        public void Dispose()
        {
            _context.Disposed = true;
            _context.Dispose();
        }

        /// <summary>
        /// Destructor on dispose.
        /// </summary>
        ~UnitOfWork()
        {
            Dispose();
        }
    }
}
