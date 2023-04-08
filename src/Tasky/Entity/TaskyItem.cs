using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Tasky.Entity;

public class TaskyItem : AggregateRoot<Guid>, IMultiTenant
{
    public string Text { get; set; } = null!;
    public bool IsCompleted { get; set; }
    public Guid? TenantId { get; }
}