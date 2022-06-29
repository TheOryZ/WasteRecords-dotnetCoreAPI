namespace WasteRecords.Core.Dtos.Unit
{
    public class UnitUpdateDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
