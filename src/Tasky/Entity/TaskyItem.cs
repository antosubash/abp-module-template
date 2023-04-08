using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Tasky.Entity;

public class TaskyItem : AggregateRoot<Guid>, IMultiTenant
{
    public string Name { get; set; } = null!;
    public Guid? TenantId { get; }
}