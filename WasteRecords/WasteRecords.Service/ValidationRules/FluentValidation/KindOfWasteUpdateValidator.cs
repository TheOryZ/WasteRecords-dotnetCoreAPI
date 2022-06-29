using FluentValidation;
using WasteRecords.Core.Dtos.KindOfWaste;

namespace WasteRecords.Service.ValidationRules.FluentValidation
{
    public class KindOfWasteUpdateValidator : AbstractValidator<KindOfWasteUpdateDto>
    {
        public KindOfWasteUpdateValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(0, int.MaxValue).WithMessage("Kind of Waste Id cannot be blank");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Kind of Waste description cannot be blank");
        }
    }
}
