using Application.Domain.EF;
using FluentValidation;
using WebApp.ViewModels;

namespace WebApp.Validators
{
    public class PersonValidator : AbstractValidator<CreateEditPersonViewModel>
    {
        public PersonValidator() { 
            RuleFor(p => p.FirstName)
                .NotEmpty()
                .MaximumLength(64);
            RuleFor(p => p.LastName)
                .NotEmpty()
                .MaximumLength(64);
        }    
    }
}
