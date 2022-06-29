using FluentValidation;
using WasteRecords.Core.Dtos.Store;

namespace WasteRecords.Service.ValidationRules.FluentValidation
{
    public class StoreAddValidator : AbstractValidator<StoreAddDto>
    {
        public StoreAddValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Store name cannot be blank");
        }
    }
}
