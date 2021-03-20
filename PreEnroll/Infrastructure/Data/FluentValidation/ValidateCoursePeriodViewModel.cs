using Enrollment.Model.Entities;
using FluentValidation;

namespace Enrollment.Infrastructure.Data.FluentValidation
{
    public class ValidateCoursePeriodViewModel: AbstractValidator<CoursePeriod>
    {
        public ValidateCoursePeriodViewModel()
        {
            RuleFor(x => x.Course.Id).NotNull();
            RuleFor(x => x.Period.Id).NotNull();
        }
    }
}
