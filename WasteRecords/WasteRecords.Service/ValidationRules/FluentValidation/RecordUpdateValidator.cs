using FluentValidation;
using WasteRecords.Core.Dtos.Record;

namespace WasteRecords.Service.ValidationRules.FluentValidation
{
    public class RecordUpdateValidator : AbstractValidator<RecordUpdateDto>
    {
        public RecordUpdateValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(0, int.MaxValue).WithMessage("Record Id cannot be blank");
            RuleFor(x => x.StoreId).InclusiveBetween(0, int.MaxValue).WithMessage("Record store Id cannot be blank");
            RuleFor(x => x.WasteTypeId).InclusiveBetween(0, int.MaxValue).WithMessage("Record waste type Id cannot be blank");
            RuleFor(x => x.KindOfWasteId).InclusiveBetween(0, int.MaxValue).WithMessage("Record kind of waste Id cannot be blank");
            RuleFor(x => x.UnitId).InclusiveBetween(0, int.MaxValue).WithMessage("Record unit Id cannot be blank");
            RuleFor(x => x.ReceivingCompanyId).InclusiveBetween(0, int.MaxValue).WithMessage("Record receiving company Id cannot be blank");
            RuleFor(x => x.Quantity).NotEmpty().WithMessage("Record quantity cannot be blank");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Record content cannot be blank");
        }
    }
}
