using System.Collections.Generic;
using Enrollment.Model.Entities;
using FluentValidation;

namespace Enrollment.Infrastructure.Data.FluentValidation
{
    public class ValidateUserEnrollment: AbstractValidator<UserEnrollment>
    {
        public ValidateUserEnrollment()
        {
           // List<ValidateCoursePeriodViewModel> ValidateCoursePeriodViewModelList = new List<ValidateCoursePeriodViewModel>();
            RuleFor(x => x.CountryId).NotNull().WithMessage("Country must be provided.");
            RuleFor(x => x.CoursePeriods).SetValidator(new InlineValidator<List<CoursePeriodViewModel>>());
            //RuleFor(x => x.CoursePeriods).SetValidator(new List<CoursePeriodViewModel>());
            //RuleFor(x => x.Orders)
            //  .Must(x => x.Count <= 10).WithMessage("No more than 10 orders are allowed")
            //  .ForEach(orderRule => {
            //	orderRule.Must(order => order.Total > 0).WithMessage("Orders must have a total of more than 0")
            //});
        }
    }
}
