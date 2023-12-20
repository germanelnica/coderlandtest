using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.PostGreSql.EntitiesConfigurations
{
    internal class CarBrandConfiguration : IEntityTypeConfiguration<CarBrand>
    {
        public void Configure(EntityTypeBuilder<CarBrand> builder)
        {
            //especifying table name
            builder.ToTable(nameof(CarBrand));
            //specifying key
            builder.HasKey(c => c.Id);
            ///declare required and max length
            builder.Property(c => c.Name).IsRequired().HasMaxLength(250);
            builder.Property(c => c.Description).HasMaxLength(250);
        }
    }
}
