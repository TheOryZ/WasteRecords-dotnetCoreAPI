using System.Collections.ObjectModel;
using WasteRecords.Core.Interfaces;

namespace WasteRecords.Core.Entities
{
    public class Unit : IEntity
    {
        public Unit()
        {
            Records = new Collection<Record>();
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Record> Records { get; set; }
    }
}
