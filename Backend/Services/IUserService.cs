using Backend.Models;

namespace Backend.Services
{
    public interface IUserService
    {
        List<User> Get();
        User get(string id);
        User Create(User user);
        void Update(string id, User user);
        void Remove(string id);
    }
}