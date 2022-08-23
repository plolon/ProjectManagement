using ProjectManagement.Domain.Entities;
using ProjectManagement.Domain.Repositories.Common;

namespace ProjectManagement.Domain.Repositories
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        Task<Project> GetProjectByOwnerId(Guid ownerId);
        Task<List<Project>> GetProjectsByUserId(Guid userId);
        Task AssignUser(Project project, User user);
    }
}
 