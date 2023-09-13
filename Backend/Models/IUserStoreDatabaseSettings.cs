namespace Backend.Models
{
    public interface IUserStoreDatabaseSettings
    {
        string UserCoursesCollectionName { get; set; }
        string ConnectionStrings { get; set; }
        string DatabaseName { get; set; }
    }
}