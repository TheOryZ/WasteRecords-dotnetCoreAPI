namespace WasteRecords.Core.Interfaces
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
