using MongoDB.Driver;

using Backend.Models;

namespace Backend.Services
{
    public class UserService : IUserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IUserStoreDatabaseSettings userStoreDatabaseSettings, IMongoClient mongoClient) 
        {
            var database = mongoClient.GetDatabase(userStoreDatabaseSettings.DatabaseName);
            _users = database.GetCollection<User>(userStoreDatabaseSettings.UserCoursesCollectionName);
        }

        public User Create(User user)
        {
            _users.InsertOne(user);
            return user;
        }

        public List<User> Get()
        {
            return _users.Find(user => true).ToList();
        }

        public User Get(string id)
        {
            return _users.Find(user => user.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _users.DeleteOne(user => user.Id == id);
        }

        public void Update(string id, User user)
        {
            _users.ReplaceOne(user => user.Id == id, user);
        }
    }
}