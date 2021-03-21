using Enrollment.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreEnroll.Model.Entities
{
    public class FormEnrollmentModel
    {
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<County> Counties { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Period> Periods { get; set; }
        public IEnumerable<DocumentType> DocumentTypes { get; set; }
        public IEnumerable<PaymentType> PaymentTypes { get; set; }
    }
}
