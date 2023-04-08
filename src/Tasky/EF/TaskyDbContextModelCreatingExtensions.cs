using Tasky.Entity;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Tasky.EF;

public static class TaskyDbContextModelCreatingExtensions
{
    public static void ConfigureTaskyItem(this ModelBuilder builder)
    {
        builder.Entity<TaskyItem>(b =>
        {
            b.ToTable("TaskyItems");
            b.ConfigureByConvention();
        });
    }
}