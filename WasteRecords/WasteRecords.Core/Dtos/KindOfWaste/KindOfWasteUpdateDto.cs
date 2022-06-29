namespace WasteRecords.Core.Dtos.KindOfWaste
{
    public class KindOfWasteUpdateDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
