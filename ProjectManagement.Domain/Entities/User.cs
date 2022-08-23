using ProjectManagement.Domain.Common.Entities;

namespace ProjectManagement.Domain.Entities
{
    public class User : BaseEntity
    {
        public string EmailAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
