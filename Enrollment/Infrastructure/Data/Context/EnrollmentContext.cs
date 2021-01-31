using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Enrollment.Infrastructure.Data.FluentApi;
using Enrollment.Model;
using Enrollment.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Enrollment.Infrastructure.Data.Context
{
    public class EnrollmentContext: DbContext
    {
        public EnrollmentContext(DbContextOptions<EnrollmentContext> options) : base(options) {}

        public DbSet<User> User { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }

         public DbSet<UserEnrollment> UserEnrollment { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           builder.ApplyConfiguration(new CountryTypeMap());
           builder.ApplyConfiguration(new CountyMap());
           builder.ApplyConfiguration(new CourseMap());
           builder.ApplyConfiguration(new DocumentTypeMap());
           builder.ApplyConfiguration(new PaymentTypeMap());
           builder.ApplyConfiguration(new PeriodMap());
           builder.ApplyConfiguration(new UserEnrollmentMap());
           builder.ApplyConfiguration(new UserMap());
        }
 
    }
}

