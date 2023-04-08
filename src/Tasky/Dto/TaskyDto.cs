using Volo.Abp.Application.Dtos;

namespace Tasky.Dto;

public class TaskyItemDto : EntityDto<Guid>
{
    public string Text { get; set; } = null!;
}