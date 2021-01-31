using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            //builder.Property(x => x.Country).IsRequired();
            //builder.Property(x => x.County).IsRequired();
            //builder.Property(x => x.Course).IsRequired();
            //builder.Property(x => x.DocumentType).IsRequired();
            //builder.Property(x => x.PaymentType).HasMaxLength(100);
            //builder.Property(x => x.User).IsRequired();
            //builder.Property(x => x.PaymentType).IsRequired();


        }
    }
}
