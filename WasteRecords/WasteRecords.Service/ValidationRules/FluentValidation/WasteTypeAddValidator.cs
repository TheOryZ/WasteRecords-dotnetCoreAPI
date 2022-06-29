using FluentValidation;
using WasteRecords.Core.Dtos.WasteType;

namespace WasteRecords.Service.ValidationRules.FluentValidation
{
    public class WasteTypeAddValidator : AbstractValidator<WasteTypeAddDto>
    {
        public WasteTypeAddValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Waste Type description cannot be blank");
        }
    }
}
