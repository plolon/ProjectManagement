using ProjectManagement.Domain.Entities;
using ProjectManagement.Domain.Repositories;
using ProjectManagement.Infrastructure.Repositories.Common;

namespace ProjectManagement.Infrastructure.Repositories
{
    public class TaskTypeRepository: GenericRepository<TaskType>, ITaskTypeRepository
    {
    }
}
