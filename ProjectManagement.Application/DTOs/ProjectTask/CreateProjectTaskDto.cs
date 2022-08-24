namespace ProjectManagement.Application.DTOs.ProjectTask
{
    public class CreateProjectTaskDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid TaskTypeId { get; set; }
        public Guid ProjectId { get; set; }
    }
}
