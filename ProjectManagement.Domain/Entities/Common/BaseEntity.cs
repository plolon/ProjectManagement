namespace ProjectManagement.Domain.Common.Entities
{
    public abstract class BaseEntity
    {
        public int Guid { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
