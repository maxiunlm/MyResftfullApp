using MyRestfullApp.Dal.Model;
using System.Collections.Generic;

namespace MyRestfullApp.Dal.Users
{
    public class UserData : IUserData
    {
        public List<User> ListAll()
        {
            return new List<User> { new User {
                Id = 1,
                Apellido = "Perez",
                Nombre = "Juan",
                Email = "juan@perez.com",
                Password = "123456"
            }};
        }

        public User Get(int id)
        {
            return new User
            {
                Id = id,
                Apellido = "Perez",
                Nombre = "Juan",
                Email = "juan@perez.com",
                Password = "123456"
            };
        }

        public void Update(User user)
        {
        }

        public void Create(User user)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
