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

        //Tager mod en user fra gui, og sender den op til wcf'en
        public bool CreateUser(ServiceReference1.User user)
        {
            return service.CreateUser(user);
        }
    }
}
