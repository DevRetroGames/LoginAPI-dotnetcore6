namespace Backend.Models
{
    public class UserStoreDatabaseSettings : IUserStoreDatabaseSettings
    {
        public string UserCoursesCollectionName { get; set; } = String.Empty;
        public string ConnectionStrings { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
    }
}