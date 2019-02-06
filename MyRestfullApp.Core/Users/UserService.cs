using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRestfullApp.Core.Model.Users;
using MyRestfullApp.Dal.Users;
using MyRestfullApp;
using AutoMapper;

namespace MyRestfullApp.Core.Users
{
    public class UserService : IUserService
    {
        private readonly IUserData data;
        private IMapper mapper;

        public UserService(IUserData data)
        {
            this.data = data;
            PreapreMapper();
        }

        public UserService()
        {
            data = new UserData();
            PreapreMapper();
        }

        private void PreapreMapper()
        {
            MapperConfiguration automappingConfiguration = new MapperConfiguration(config =>
            {
                config.CreateMap<User, Dal.Model.User>();
                config.CreateMap<Dal.Model.User, User>();
            });

            mapper = automappingConfiguration.CreateMapper();
        }

        public List<User> ListAll()
        {
            List<Dal.Model.User> raw = data.ListAll();
            List<User> users = raw.Select(o => mapper.Map<User>(o)).ToList();

            return users;
        }

        public User Get(int id)
        {
            Dal.Model.User raw = data.Get(id);
            User user = mapper.Map<User>(raw);

            return user;
        }

        public void Update(User user)
        {
            Dal.Model.User raw = mapper.Map<Dal.Model.User>(user);

            data.Update(raw);
        }

        public void Create(User user)
        {
            Dal.Model.User raw = mapper.Map<Dal.Model.User>(user);

            data.Create(raw);
        }

        public void Delete(int id)
        {
            data.Delete(id);
        }
    }
}
