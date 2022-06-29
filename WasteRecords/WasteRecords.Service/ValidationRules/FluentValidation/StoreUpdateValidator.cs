using FluentValidation;
using WasteRecords.Core.Dtos.Store;

namespace WasteRecords.Service.ValidationRules.FluentValidation
{
    public class StoreUpdateValidator : AbstractValidator<StoreUpdateDto>
    {
        public StoreUpdateValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(0, int.MaxValue).WithMessage("Store Id cannot be blank");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Store name cannot be blank");
        }
    }
}
