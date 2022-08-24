namespace ProjectManagement.Application.DTOs.Todos
{
    public class UpdateTodoDto : AddTodoDto
    {
        public Guid Id { get; set; }
    }
}
