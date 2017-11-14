using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClientTest
{
    [TestClass]
    public class CreateUserTest
    {
        [TestMethod]
        public void TestUserIsCreated()
        {

            //Arrange
            //UserController userController = new UserController();

            UserManagement userManagement = new UserManagement(); //Her kalder vi metoden som opretter en user i GUI'en.

            //Act
            userController.Create("TestUser");

            User testUserCreate = new User("TestUser");

            userManagement.Create(int id, string role, string firstname, string lastname, string password);

            //Assert
            User user = userController.Get();
            Assert.ReferenceEquals(user, testUser);


        }
    }
}


