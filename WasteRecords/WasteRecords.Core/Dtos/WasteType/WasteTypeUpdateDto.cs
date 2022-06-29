namespace WasteRecords.Core.Dtos.WasteType
{
    public class WasteTypeUpdateDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
