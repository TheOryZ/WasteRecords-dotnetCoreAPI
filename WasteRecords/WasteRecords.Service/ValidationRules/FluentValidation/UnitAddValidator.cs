using FluentValidation;
using WasteRecords.Core.Dtos.Unit;

namespace WasteRecords.Service.ValidationRules.FluentValidation
{
    public class UnitAddValidator : AbstractValidator<UnitAddDto>
    {
        public UnitAddValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Unit description cannot be blank");
        }
    }
}
