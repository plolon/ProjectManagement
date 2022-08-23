using ProjectManagement.Domain.Entities;
using ProjectManagement.Domain.Repositories;
using ProjectManagement.Infrastructure.Repositories.Common;

namespace ProjectManagement.Infrastructure.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        private readonly ProjectManagementDbContext dbContext;

        public CommentRepository(ProjectManagementDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
