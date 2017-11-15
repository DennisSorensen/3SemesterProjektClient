//using Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class UserService
    {
        //Laver en instans af vores service reference, sådan vi kan kalde dem
        ServiceReference1.IService1 service = new ServiceReference1.Service1Client();

        public void CreateUser(int id, string role, string firstName, string lastName, string password)
        {
            //Skal kalde servicen, og sende et user obj med
            ServiceReference1.User user = new ServiceReference1.User();
            user.Id = id;
            user.Role = role;
            user.LastName = firstName;
            user.FirstName = lastName;
            user.Password = password;

            service.CreateUser(user);
        }
    }
}
