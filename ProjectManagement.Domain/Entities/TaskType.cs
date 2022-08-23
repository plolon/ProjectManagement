using ProjectManagement.Domain.Common.Entities;

namespace ProjectManagement.Domain.Entities
{
        
    public class TaskType : BaseEntity
    {
        public string Name { get; set; }
        public string ColorHex { get; set; }
    }
}
