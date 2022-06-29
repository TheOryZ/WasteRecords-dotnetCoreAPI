namespace WasteRecords.Core.Dtos.Store
{
    public class StoreUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
