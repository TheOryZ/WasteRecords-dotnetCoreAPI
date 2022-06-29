using FluentValidation;
using WasteRecords.Core.Dtos.ReceivingCompany;

namespace WasteRecords.Service.ValidationRules.FluentValidation
{
    public class ReceivingCompanyAddValidator : AbstractValidator<ReceivingCompanyAddDto>
    {
        public ReceivingCompanyAddValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Receiving Company description cannot be blank");
        }
    }
}
