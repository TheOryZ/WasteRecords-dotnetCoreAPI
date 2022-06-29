using FluentValidation;
using WasteRecords.Core.Dtos.ReceivingCompany;

namespace WasteRecords.Service.ValidationRules.FluentValidation
{
    public class ReceivingCompanyUpdateValidator : AbstractValidator<ReceivingCompanyUpdateDto>
    {
        public ReceivingCompanyUpdateValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(0, int.MaxValue).WithMessage("Receiving Company Id cannot be blank");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Receiving Company description cannot be blank");
        }
    }
}
