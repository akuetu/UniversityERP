using Enrollment.Model.Entities;
using FluentValidation;

namespace Enrollment.Services.Validators
{
    public class CountryValidator: AbstractValidator<Country>  
    {
        public CountryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("the name cannot be blank");
        }
    }
}
