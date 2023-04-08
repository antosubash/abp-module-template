using Tasky.Dto;
using Tasky.Entity;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Features;

namespace Tasky.Application;

[Authorize(TaskyPermissions.TaskyItem.Default)]
[RequiresFeature(TaskyFeatures.MyFeature1.Name)]
public class TaskyApplicationService : ApplicationService
{
    private readonly IRepository<TaskyItem, Guid> _repository;

    public TaskyApplicationService(IRepository<TaskyItem, Guid> repository)
    {
        _repository = repository;
    }
    
    public virtual async Task<List<TaskyItemDto>> GetListAsync()
    {
        var items = await _repository.GetListAsync();
        return ObjectMapper.Map<List<TaskyItem>, List<TaskyItemDto>>(items);
    }

    public virtual async Task<TaskyItemDto> GetAsync(Guid id)
    {
        var item = await _repository.GetAsync(id);
        return ObjectMapper.Map<TaskyItem, TaskyItemDto>(item);
    }

    [Authorize(TaskyPermissions.TaskyItem.Create)]
    public virtual async Task<TaskyItemDto> CreateAsync(TaskyItemDto input)
    {
        var item = ObjectMapper.Map<TaskyItemDto, TaskyItem>(input);
        item = await _repository.InsertAsync(item);
        return ObjectMapper.Map<TaskyItem, TaskyItemDto>(item);
    }

    [Authorize(TaskyPermissions.TaskyItem.Update)]
    public virtual async Task<TaskyItemDto> UpdateAsync(Guid id, TaskyItemDto input)
    {
        var item = await _repository.GetAsync(id);
        ObjectMapper.Map(input, item);
        item = await _repository.UpdateAsync(item);
        return ObjectMapper.Map<TaskyItem, TaskyItemDto>(item);
    }

    [Authorize(TaskyPermissions.TaskyItem.Delete)]
    public virtual async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
    }

}