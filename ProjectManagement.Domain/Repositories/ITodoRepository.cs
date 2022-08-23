using ProjectManagement.Domain.Entities;
using ProjectManagement.Domain.Repositories.Common;

namespace ProjectManagement.Domain.Repositories
{
    public interface ITodoRepository : IGenericRepository<Todo>
    {
        Task<List<Todo>> GetTodosByProjectId(Guid projectId);
    }
}
