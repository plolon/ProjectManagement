namespace ProjectManagement.Application.DTOs.Project
{
    public class CreateProjectDto
    {
        public Guid OwnerId { get; set; }
        public string Name { get; set; }
    }
}
