namespace ProjectManagement.API.DTOs.Comment
{
    public class UpdateCommentDto : CreateCommentDto
    {
        public Guid Id { get; set; }
    }
}
