using System;

namespace PreEnroll.Model.Entities
{
    public class EnrollmentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public bool HasDisability { get; set; }
        public string Country { get; set; }
        public string Coutry { get; set; }
        public string PaymentType { get; set; }
        public DateTime Date { get; set; }

    }
}
