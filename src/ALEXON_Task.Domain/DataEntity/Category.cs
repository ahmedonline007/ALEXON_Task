using Volo.Abp.Domain.Entities.Auditing;

namespace ALEXON_Task.DataEntity
{
    public class Category : FullAuditedEntity<int>
    {
        public Category(int id, string name) : base(id)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}