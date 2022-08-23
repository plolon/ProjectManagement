using ProjectManagement.Domain.Entities;
using ProjectManagement.Domain.Repositories;
using ProjectManagement.Infrastructure.Repositories.Common;

namespace ProjectManagement.Infrastructure.Repositories
{
    public class ProjectTaskRepository : GenericRepository<ProjectTask>, IProjectTaskRepository
    {
        private readonly ProjectManagementDbContext dbContext;

        public ProjectTaskRepository(ProjectManagementDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<List<ProjectTask>> GetProjectTasksByProjectId(Guid projectId)
        {
            throw new NotImplementedException();
        }
    }
}
