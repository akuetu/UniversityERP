using Enrollment.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Enrollment.Infrastructure.Data.FluentApi
{
    public class UserEnrollmentMap:IEntityTypeConfiguration<UserEnrollment>
    {
        public void Configure(EntityTypeBuilder<UserEnrollment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Note).HasMaxLength(5000);
            builder.Property(x => x.PathTypeDocument).HasMaxLength(100);
            builder.Property(x => x.PathTypePayment).HasMaxLength(100);
            builder.Property(x => x.CountryId).IsRequired();
            builder.Property(x => x.CountyId).IsRequired();
            builder.Property(x => x.DocumentTypeId).IsRequired();
            builder.Property(x => x.PaymentTypeId).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
            builder.HasMany(x => x.CoursePeriods);
        }
    }
}
