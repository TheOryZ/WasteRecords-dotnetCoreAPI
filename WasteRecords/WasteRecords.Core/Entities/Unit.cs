using WasteRecords.Core.Interfaces;

namespace WasteRecords.Core.Entities
{
    public class Unit : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
