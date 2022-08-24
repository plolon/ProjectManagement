namespace ProjectManagement.Application.DTOs.Todos
{
    public class UpdateTodoDto : CreateTodoDto
    {
        public Guid Id { get; set; }
    }
}
