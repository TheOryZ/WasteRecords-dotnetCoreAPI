namespace WasteRecords.Core.Dtos.ReceivingCompany
{
    public class ReceivingCompanyUpdateDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
