using System.Collections.ObjectModel;
using WasteRecords.Core.Interfaces;

namespace WasteRecords.Core.Entities
{
    public class Store : IEntity
    {
        public Store()
        {
            Records = new Collection<Record>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Record> Records { get; set; }
    }
}
