using System.Collections.Generic;

namespace Enrollment.Model.Entities
{
    public class UserEnrollment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DocumentTypeId { get; set; }
        public string PathTypeDocument { get; set; }
        public int CountryId { get; set; }
        public  int CountyId { get; set; }
        public List<CoursePeriodViewModel> CoursePeriods { get; set; } = new List<CoursePeriodViewModel>();
        //public int CourseId { get; set; }
       // public int PeriodId { get; set; }
        public  int PaymentTypeId { get; set; }
        public string PathTypePayment { get; set; }
        public string Note { get; set; }

    }
}
