using ProjectManagement.Domain.Entities;
using ProjectManagement.Domain.Repositories;
using ProjectManagement.Infrastructure.Repositories.Common;

namespace ProjectManagement.Infrastructure.Repositories
{
    public class TodoRepository : GenericRepository<Todo>, ITodoRepository
    {
        public Task<List<Todo>> GetTodosByProjectId(Guid projectId)
        {
            throw new NotImplementedException();
        }
    }
}
