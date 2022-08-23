using ProjectManagement.Domain.Entities;
using ProjectManagement.Domain.Repositories;
using ProjectManagement.Infrastructure.Repositories.Common;

namespace ProjectManagement.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly ProjectManagementDbContext dbContext;

        public UserRepository(ProjectManagementDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<List<User>> GetUsersByProjectId(Guid projectId)
        {
            throw new NotImplementedException();
        }
    }
}
