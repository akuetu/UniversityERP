using System.Collections.Generic;
using Enrollment.Model.Entities;
using FluentValidation;

namespace Enrollment.Infrastructure.Data.FluentValidation
{
    public class ValidateUserEnrollment: AbstractValidator<UserEnrollment>
    {
        public ValidateUserEnrollment()
        {
            RuleFor(x => x.CountryId).NotNull().WithMessage("Country must be provided.");
            RuleFor(x => x.CountyId).NotNull().WithMessage("Country must be provided.");
            RuleFor(x => x.CoursePeriods).NotNull().WithMessage("Country must be provided.");
            
        }
    }
}
