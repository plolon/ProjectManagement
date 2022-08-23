using ProjectManagement.Domain.Entities;
using ProjectManagement.Domain.Repositories;
using ProjectManagement.Infrastructure.Repositories.Common;

namespace ProjectManagement.Infrastructure.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        private readonly ProjectManagementDbContext dbContext;

        public ProjectRepository(ProjectManagementDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task AssignUser(Project project, User user)
        {
            throw new NotImplementedException();
        }

        public Task<Project> GetProjectByOwnerId(Guid ownerId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Project>> GetProjectsByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
