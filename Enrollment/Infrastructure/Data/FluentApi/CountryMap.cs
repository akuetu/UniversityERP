using Enrollment.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Enrollment.Infrastructure.Data.FluentApi
{

    public class CountryTypeMap : IEntityTypeConfiguration<Country>
        {
            public void Configure(EntityTypeBuilder<Country> builder)
            {
                builder.HasKey(x => x.Id);
                builder.HasIndex(x=> x.Name).IsUnique();
                builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
        }
        }
     
}
