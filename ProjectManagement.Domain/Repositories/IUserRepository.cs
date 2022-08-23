using ProjectManagement.Domain.Entities;
using ProjectManagement.Domain.Repositories.Common;

namespace ProjectManagement.Domain.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<List<User>> GetUsersByProjectId(Guid projectId);
    }
}
