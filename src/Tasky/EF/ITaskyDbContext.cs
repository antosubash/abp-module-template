namespace MyCompanyName.MyProjectName.EF;

public interface ITaskyDbContext
{
    DbSet<TaskyItem> TaskyItems { get; set; }
}