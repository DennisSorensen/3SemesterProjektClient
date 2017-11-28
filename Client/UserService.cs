using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class UserService
    {
        //Laver en instans af vores service reference, sådan vi kan kalde dem
        UserServiceReference.IUserService userService = new UserServiceReference.UserServiceClient();

        //Tager mod en user fra gui, og sender den op til wcf'en
        public bool CreateUser(UserServiceReference.User user)
        {
            return userService.CreateUser(user);
        }
        
        public IEnumerable<UserServiceReference.User> GetAllSupporters()
        {
            return userService.GetAllSupporters();
        }
        

        public UserServiceReference.User GetUser(int id)
        {
            return userService.GetUser(id);
        }

        public IEnumerable<UserServiceReference.User> GetAllUsers()
        {
            return userService.GetAll();
        }
    }
}
