namespace ProjectManagement.Application.DTOs.Comment
{
    public class CreateCommentDto
    {
        public string Content { get; set; }
        public Guid ProjectTaskId { get; set; }
    }
}
