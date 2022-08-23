using ProjectManagement.Domain.Entities;
using ProjectManagement.Domain.Repositories.Common;

namespace ProjectManagement.Domain.Repositories
{
    public interface IProjectTaskRepository : IGenericRepository<ProjectTask>
    {
        Task<List<ProjectTask>> GetProjectTasksByProjectId(Guid projectId);
    }
}
