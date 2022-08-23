using ProjectManagement.Domain.Common.Entities;

namespace ProjectManagement.Domain.Entities
{
    public class Project : BaseEntity
    {
        public User Owner { get; set; }
        public Guid OwnerId { get; set; }
        public string Name { get; set; }
        public List<ProjectTask> Tasks { get; set; }
        public int Percent { get; set; }
        public List<User> Users { get; set; }
        public bool Status { get; set; }
    }
}
