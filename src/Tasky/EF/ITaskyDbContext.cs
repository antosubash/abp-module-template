using Microsoft.EntityFrameworkCore;
using Tasky.Entity;

namespace Tasky.EF;

public interface ITaskyDbContext
{
    DbSet<TaskyItem> TaskyItems { get; set; }
}