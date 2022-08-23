using ProjectManagement.Domain.Common.Entities;

namespace ProjectManagement.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; }
        public Guid ProjectTaskId { get; set; }
        public Guid TodoId { get; set; }
    }
}
