using Tasky.Dto;
using Tasky.Entity;

namespace Tasky.Profile;

public class TaskyAutoMapperProfile : AutoMapper.Profile
{
    public TaskyAutoMapperProfile()
    {
        CreateMap<TaskyItem, TaskyItemDto>();
        CreateMap<TaskyItemDto, TaskyItem>();
    }
}