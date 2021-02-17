using Enrollment.Model.Entities;
using FluentValidation;

namespace Enrollment.Infrastructure.Data.FluentValidation
{
    public class ValidateCoursePeriodViewModel: AbstractValidator<CoursePeriod>
    {
        public ValidateCoursePeriodViewModel()
        {
            RuleFor(x => x.CourseId).NotNull();
            RuleFor(x => x.PeriodId).NotNull();
        }
    }
}
