namespace ProjectManagement.API.DTOs.Todos
{
    public class AddTodoDto
    {
        public string Name { get; set; }
        public Guid ProjectTaskId { get; set; }
    }
}
