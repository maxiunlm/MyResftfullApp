using System.Linq;
using MyRestfullApp.Dal.Model;
using System.Collections.Generic;

namespace MyRestfullApp.Dal.Users
{
    public class UserData : IUserData
    {
        public Context context;

        public UserData()
        {
            context = new Context();
        }

        public UserData(Context context)
        {
            this.context = context;
        }

        public List<User> ListAll()
        {
            //////return new List<User> { new User {
            //////    Id = 1,
            //////    Apellido = "Perez",
            //////    Nombre = "Juan",
            //////    Email = "juan@perez.com",
            //////    Password = "123456"
            //////}};
            return context.user.OrderBy(o => o.Nombre).ThenBy(o => o.Apellido).ToList();
        }

        public User Get(int id)
        {
            //////return new User
            //////{
            //////    Id = id,
            //////    Apellido = "Perez",
            //////    Nombre = "Juan",
            //////    Email = "juan@perez.com",
            //////    Password = "123456"
            //////};
            return context.user.Where(o => o.Id == id).SingleOrDefault() ?? new User();
        }

        public void Update(User user)
        {
            User dbUser = context.user.Where(o => o.Id == user.Id).Single();
            //context.user.Attach(dbUser);

            dbUser.Nombre = user.Nombre;
            dbUser.Apellido = user.Apellido;
            dbUser.Email = user.Email;
            dbUser.Password = user.Password;

            context.SaveChanges();
        }

        public void Create(User user)
        {
            context.user.Add(user);

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            User user = context.user.Where(o => o.Id == id).Single();
            context.user.Remove(user);

            context.SaveChanges();
        }
    }
}
