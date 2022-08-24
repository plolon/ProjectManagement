namespace ProjectManagement.API.DTOs.Todos
{
    public class UpdateTodoDto : AddTodoDto
    {
        public Guid Id { get; set; }
    }
}
