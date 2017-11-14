using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class WCFConection
    {
        //Laver en instans af vores service reference, sådan vi kan kalde dem
        ServiceReference1.IService1 service = new ServiceReference1.Service1Client();

        public WCFConection()
        {
            
        }

        public void CreateUser(ServiceReference1.User user)
        {
            service.CreateUser(user);
        }

    }

    

}
