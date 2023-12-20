using Application.Interfaces;
using Domain.Entities;

namespace Persistence.PostGreSql.Repositories
{
    internal class CardBrandRepository : GenericRepository<CarBrand>, ICarBrandRepository
    {
        public CardBrandRepository(DatabaseContext context) : base(context)
        {
        }
    }
}