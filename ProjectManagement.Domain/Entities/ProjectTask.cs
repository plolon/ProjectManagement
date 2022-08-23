using ProjectManagement.Domain.Common.Entities;

namespace ProjectManagement.Domain.Entities
{
    public class ProjectTask : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Type Type { get; set; }
        public bool Status { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Comment> Todos { get; set; }
        public Guid ProjectId { get; set; }
    }
}
