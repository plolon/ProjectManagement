using ProjectManagement.Domain.Common.Entities;

namespace ProjectManagement.Domain.Entities
{
    public class Todo : BaseEntity
    {
        public string Name { get; set; }
        public Guid ProjectTaskId { get; set; }
        public bool Status { get; set; }
    }
}
