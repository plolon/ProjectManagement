using AutoMapper;
using ProjectManagement.Application.DTOs.Comment;
using ProjectManagement.Application.DTOs.Project;
using ProjectManagement.Application.DTOs.ProjectTask;
using ProjectManagement.Application.DTOs.TaskType;
using ProjectManagement.Application.DTOs.Todos;
using ProjectManagement.Application.DTOs.Users;
using ProjectManagement.Domain.Entities;

namespace ProjectManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, CreateUserDto>().ReverseMap();
            CreateMap<User, UpdateUserDto>().ReverseMap();

            CreateMap<Todo, CreateTodoDto>().ReverseMap();
            CreateMap<Todo, UpdateTodoDto>().ReverseMap();
            CreateMap<Todo, ChangeStatusTodoDto>().ReverseMap();

            CreateMap<TaskType, CreateTaskTypeDto>().ReverseMap();
            CreateMap<TaskType, UpdateTaskTypeDto>().ReverseMap();

            CreateMap<ProjectTask, CreateProjectTaskDto>().ReverseMap();
            CreateMap<ProjectTask, UpdateProjectTaskDto>().ReverseMap();
            CreateMap<ProjectTask, ChangeStatusProjectTaskDto>().ReverseMap();

            CreateMap<Project, CreateProjectDto>().ReverseMap();
            CreateMap<Project, UpdateProjectDto>().ReverseMap();
            CreateMap<Project, ChangePercentProjectDto>().ReverseMap();
            CreateMap<Project, ChangeStatusProjectDto>().ReverseMap();

            CreateMap<Comment, CreateCommentDto>().ReverseMap();
            CreateMap<Comment, UpdateCommentDto>().ReverseMap();
        }
    }
}
