namespace Enrollment.Model.Entities
{
    public class CoursePeriod
    {
        public int Id { get; set; }
        public Course Course { get; set; }
       public Period Period { get; set; }
        public UserEnrollment UserEnrollment { get; set; }
    }
}
