using FluentValidation;

namespace Company.Application.DTOs.CompanyDTO.Validators
{
    public class CreateCompanyDTOValidator : AbstractValidator<CreateCompanyDTO>
    {
        public CreateCompanyDTOValidator()
        {
            RuleFor(p => p.CompanyName)
                .NotEmpty()
                .WithMessage("{PropertyName}")
                .NotNull()
                .MaximumLength(50)
                .WithMessage("Can't greater then 50 Words.");
        }
    }
}
