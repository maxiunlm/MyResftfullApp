using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyRestfullApp.Core.Model.Users;
using MyRestfullApp.Core.Users;
using MyRestfullApp.Dal.Users;
using MyRestfullApp;
using System.Linq;

namespace MyRestfullApp.UnitTest.Core
{
    [TestClass]
    public class UserServiceUnitTests
    {
        private const int id1 = 1;
        private const int id2 = 2;
        private static readonly User userParameter = new User
        {
            Id = id1,
            Apellido = "Perez",
            Nombre = "Juan",
            Email = "juan@perez.com",
            Password = "123456"
        };
        private static readonly Dal.Model.User user1 = new Dal.Model.User
        {
            Id = id1,
            Apellido = "Perez",
            Nombre = "Juan",
            Email = "juan@perez.com",
            Password = "123456"
        };
        private static readonly Dal.Model.User user2 = new Dal.Model.User
        {
            Id = id2,
            Apellido = "Garcia",
            Nombre = "Carlos",
            Email = "carlos@garcia.com",
            Password = "67890"
        };
        private static readonly List<Dal.Model.User> usersX0 = new List<Dal.Model.User>();
        private static readonly List<Dal.Model.User> usersX1 = new List<Dal.Model.User> { user1 };
        private static readonly List<Dal.Model.User> usersX2 = new List<Dal.Model.User> { user1, user2 };

        private Mock<IUserData> mocker;

        [TestInitialize]
        public void DoBeforeEach()
        {
            mocker = new Mock<IUserData>();
        }

        [TestMethod]
        public void ListAll_WithoutParameter_InvokesListAllMethodFromUserDadaObject()
        {
            mocker.Setup(o => o.ListAll()).Returns(usersX1);
            IUserData data = mocker.Object;
            IUserService sut = new UserService(data);

            sut.ListAll();

            mocker.Verify(o => o.ListAll(), Times.Once);
        }

        [TestMethod]
        public void ListAll_WithoutParameter_ReturnsAnEmptyList()
        {
            mocker.Setup(o => o.ListAll()).Returns(usersX0);
            IUserData data = mocker.Object;
            IUserService sut = new UserService(data);

            List<User> users = sut.ListAll();

            Assert.IsTrue(usersX0.Count == users.Count);
            Assert.IsTrue(users.Count == 0);
        }

        [TestMethod]
        public void ListAll_WithoutParameter_ReturnsOneUser()
        {
            mocker.Setup(o => o.ListAll()).Returns(usersX1);
            IUserData data = mocker.Object;
            IUserService sut = new UserService(data);

            List<User> users = sut.ListAll();

            Assert.AreEqual(usersX1.First().Id, users.First().Id);
            Assert.AreEqual(usersX1.First().Nombre, users.First().Nombre);
            Assert.AreEqual(usersX1.First().Apellido, users.First().Apellido);
            Assert.AreEqual(usersX1.First().Email, users.First().Email);
            Assert.AreEqual(usersX1.First().Password, users.First().Password);
            Assert.IsTrue(users.Count == 1);
        }

        [TestMethod]
        public void ListAll_WithoutParameter_ReturnsTwoUsers()
        {
            mocker.Setup(o => o.ListAll()).Returns(usersX2);
            IUserData data = mocker.Object;
            IUserService sut = new UserService(data);

            List<User> users = sut.ListAll();

            Assert.AreEqual(usersX2.First().Id, users.First().Id);
            Assert.AreEqual(usersX2.First().Nombre, users.First().Nombre);
            Assert.AreEqual(usersX2.First().Apellido, users.First().Apellido);
            Assert.AreEqual(usersX2.First().Email, users.First().Email);
            Assert.AreEqual(usersX2.First().Password, users.First().Password);
            Assert.AreEqual(usersX2.Last().Id, users.Last().Id);
            Assert.AreEqual(usersX2.Last().Nombre, users.Last().Nombre);
            Assert.AreEqual(usersX2.Last().Apellido, users.Last().Apellido);
            Assert.AreEqual(usersX2.Last().Email, users.Last().Email);
            Assert.AreEqual(usersX2.Last().Password, users.Last().Password);
            Assert.IsTrue(users.Count == 2);
        }

        [TestMethod]
        public void Get_WithIdParameter_InvokesGetMethodFromUserDadaObject()
        {
            mocker.Setup(o => o.Get(id1)).Returns(user1);
            IUserData data = mocker.Object;
            IUserService sut = new UserService(data);

            sut.Get(id1);

            mocker.Verify(o => o.Get(id1), Times.Once);
        }

        [TestMethod]
        public void Get_WithIdParameter_ReturnsOneUser()
        {
            mocker.Setup(o => o.Get(id1)).Returns(user1);
            IUserData data = mocker.Object;
            IUserService sut = new UserService(data);

            User user = sut.Get(id1);

            Assert.AreEqual(user1.Id, user.Id);
            Assert.AreEqual(user1.Nombre, user.Nombre);
            Assert.AreEqual(user1.Apellido, user.Apellido);
            Assert.AreEqual(user1.Email, user.Email);
            Assert.AreEqual(user1.Password, user.Password);
        }

        [TestMethod]
        public void Update_WithUserParameter_InvokesUpdateMethodFromUserDadaObject()
        {
            mocker.Setup(o => o.Update(It.IsAny<Dal.Model.User>()));
            IUserData data = mocker.Object;
            IUserService sut = new UserService(data);

            sut.Update(userParameter);

            mocker.Verify(o => o.Update(It.IsAny<Dal.Model.User>()), Times.Once);
        }

        [TestMethod]
        public void Create_WithUserParameter_InvokesCreateMethodFromUserDadaObject()
        {
            mocker.Setup(o => o.Create(It.IsAny<Dal.Model.User>()));
            IUserData data = mocker.Object;
            IUserService sut = new UserService(data);

            sut.Create(userParameter);

            mocker.Verify(o => o.Create(It.IsAny<Dal.Model.User>()), Times.Once);
        }

        [TestMethod]
        public void Delete_WithIdParameter_InvokesDeleteMethodFromUserDadaObject()
        {
            mocker.Setup(o => o.Delete(id1));
            IUserData data = mocker.Object;
            IUserService sut = new UserService(data);

            sut.Delete(id1);

            mocker.Verify(o => o.Delete(id1), Times.Once);
        }
    }
}
