using FluentValidation;
using WasteRecords.Core.Dtos.KindOfWaste;

namespace WasteRecords.Service.ValidationRules.FluentValidation
{
    public class KindOfWasteAddValidator : AbstractValidator<KindOfWasteAddDto>
    {
        public KindOfWasteAddValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Kind of Waste description cannot be blank");
        }
    }
}
