namespace ProjectManagement.Application.DTOs.Todos
{
    public class CreateTodoDto
    {
        public string Name { get; set; }
        public Guid ProjectTaskId { get; set; }
    }
}
