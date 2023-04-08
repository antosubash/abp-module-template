using MyCompanyName.MyProjectName.Dto;
using MyCompanyName.MyProjectName.Entity;

namespace MyCompanyName.MyProjectName.Profile;

public class TaskyAutoMapperProfile : AutoMapper.Profile
{
    public TaskyAutoMapperProfile()
    {
        CreateMap<TaskyItem, TaskyItemDto>();
        CreateMap<TaskyItemDto, TaskyItem>();
    }
}