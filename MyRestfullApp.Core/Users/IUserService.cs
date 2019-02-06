using System.Collections.Generic;
using MyRestfullApp.Core.Model.Users;

namespace MyRestfullApp.Core.Users
{
    public interface IUserService
    {
        void Create(User user);
        void Delete(int id);
        User Get(int id);
        List<User> ListAll();
        void Update(User user);
    }
}