using Volo.Abp.Application.Dtos;

namespace MyCompanyName.MyProjectName.Dto;

public class TaskyItemDto : EntityDto<Guid>
{
    public string Text { get; set; } = null!;
    public bool IsCompleted { get; set; }
}