using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;

namespace ClientTest
{
    [TestClass]
    public class CreateUserTest
    {
        [TestMethod]
        public void TestUserIsCreated()
        {
            UserService userService = new UserService();

            Client.UserServiceReference.User user = new Client.UserServiceReference.User();

            user.Id = 33;
            user.Role = "Admin";
            user.FirstName = "Dennis";
            user.LastName = "Sørensen";
            user.Password = "1234";

            Assert.IsTrue(userService.CreateUser(user));
            /*
            //Arrange
            //UserController userController = new UserController();

            UserManagement userManagement = new UserManagement(); //Her kalder vi metoden som opretter en user i GUI'en.

            //Act
            //userController.Create("TestUser");

            Client.UserServiceReference.User testUser = new User(1, "Admin", "Bo", "Hansen", "A1234");

            userManagement.Create(1, "Admin", "Bo", "Hansen", "A1234");

            testUser.
            //Assert
            //User user = userController.Get();
            User user = userManagement.get(id);
            Assert.ReferenceEquals(user, testUser);
            */

            

        }
    }
}


