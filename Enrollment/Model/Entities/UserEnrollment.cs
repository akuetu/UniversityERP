using System.Collections.Generic;

namespace Enrollment.Model.Entities
{
    public class UserEnrollment
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<DocumentType> DocumentType { get; set; }
        public string PathTypeDocument { get; set; }
        public List<Country> Country { get; set; }
        public List<County> County { get; set; }
        public List<Course> Course { get; set; }
        public List<Period> Period { get; set; }
        public List<PaymentType> PaymentType{ get; set; }
        public string PathTypePayment { get; set; }
        public string Note { get; set; }


    }
}
