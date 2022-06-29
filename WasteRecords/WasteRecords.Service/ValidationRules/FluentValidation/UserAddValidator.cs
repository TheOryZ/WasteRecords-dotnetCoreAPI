using FluentValidation;
using WasteRecords.Core.Dtos.User;

namespace WasteRecords.Service.ValidationRules.FluentValidation
{
    public class UserAddValidator : AbstractValidator<UserAddDto>
    {
        public UserAddValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("User email cannot be blank");
            RuleFor(x => x.Password).NotEmpty().WithMessage("User password cannot be blank");
            RuleFor(x => x.Name).NotEmpty().WithMessage("User name cannot be blank");
        }
    }
}
