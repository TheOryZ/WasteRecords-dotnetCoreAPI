using FluentValidation;
using WasteRecords.Core.Dtos.Unit;

namespace WasteRecords.Service.ValidationRules.FluentValidation
{
    public class UnitUpdateValidator : AbstractValidator<UnitUpdateDto>
    {
        public UnitUpdateValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(0, int.MaxValue).WithMessage("Unit Id cannot be blank");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Unit description cannot be blank");
        }
    }
}
