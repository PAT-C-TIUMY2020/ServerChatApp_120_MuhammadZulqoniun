using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFService_2Way_120;
using System.ServiceModel;

namespace ServerChatApp_120_MuhammadZulqoniun
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObject = null;
            try
            {
                hostObject = new ServiceHost(typeof(ServiceCallback));
                hostObject.Open();

                Console.WriteLine("Server On, Ready to use");
                Console.ReadLine();

                hostObject.Close();
            }
            catch (Exception ex)
            {
                hostObject = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}