namespace ProjectManagement.Application.DTOs.Todos
{
    public class ChangeStatusTodoDto
    {
        public Guid Id { get; set; }
        public bool Status { get; set; }
    }
}
