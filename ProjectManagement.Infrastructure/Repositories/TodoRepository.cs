using ProjectManagement.Domain.Entities;
using ProjectManagement.Domain.Repositories;
using ProjectManagement.Infrastructure.Repositories.Common;

namespace ProjectManagement.Infrastructure.Repositories
{
    public class TodoRepository : GenericRepository<Todo>, ITodoRepository
    {
        private readonly ProjectManagementDbContext dbContext;

        public TodoRepository(ProjectManagementDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<List<Todo>> GetTodosByProjectId(Guid projectId)
        {
            throw new NotImplementedException();
        }
    }
}
