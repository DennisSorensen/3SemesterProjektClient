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
        /*
        With normal return you must have the complete list before returning. By using yield-return, you really only need to have the next item before returning.
        Among other things, this helps spread the computational cost of complex calculations over a larger time-frame.
        For example, if the list is hooked up to a GUI and the user never goes to the last page, you never calculate 
        the final items in the list.
        Another case where yield-return is preferable is if the IEnumerable represents an infinite set. 
        Consider the list of Prime Numbers, or an infinite list of random numbers.You can never return the full 
        IEnumerable at once, so you use yield-return to return the list incrementally.
        https://stackoverflow.com/questions/410026/proper-use-of-yield-return
        17-11-2017 
        */
        public IEnumerable<UserServiceReference.User> GetAllSupporters()
        {
            yield return userService.GetAllSupporters();
        }

        public UserServiceReference.User GetUser(int id)
        {
            return userService.GetUser(id);
        }
    }
}
