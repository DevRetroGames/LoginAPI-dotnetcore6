namespace Backend.Models
{
    public class UserStoreDatabaseSettings : IUserStoreDatabaseSettings
    {
        string IUserStoreDatabaseSettings.UserCoursesCollectionName { get; set; } = String.Empty;
        string IUserStoreDatabaseSettings.ConnectionStrings { get; set; } = String.Empty;
        string IUserStoreDatabaseSettings.DatabaseName { get; set; } = String.Empty;
    }
}