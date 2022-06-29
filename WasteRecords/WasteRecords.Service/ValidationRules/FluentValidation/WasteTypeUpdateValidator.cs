using FluentValidation;
using WasteRecords.Core.Dtos.WasteType;

namespace WasteRecords.Service.ValidationRules.FluentValidation
{
    public class WasteTypeUpdateValidator : AbstractValidator<WasteTypeUpdateDto>
    {
        public WasteTypeUpdateValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(0, int.MaxValue).WithMessage("Waste Type Id cannot be blank");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Waste Type description cannot be blank");
        }
    }
}
