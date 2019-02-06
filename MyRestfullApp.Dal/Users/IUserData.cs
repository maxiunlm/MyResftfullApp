using System.Collections.Generic;
using MyRestfullApp.Dal.Model;

namespace MyRestfullApp.Dal.Users
{
    public interface IUserData
    {
        void Create(User user);
        void Delete(int id);
        User Get(int id);
        List<User> ListAll();
        void Update(User user);
    }
}