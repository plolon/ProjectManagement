using ProjectManagement.Domain.Common.Entities;

namespace ProjectManagement.Domain.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }
        public int Percent { get; set; }
        public List<User> Users { get; set; }
        public bool Status { get; set; }
    }
}
