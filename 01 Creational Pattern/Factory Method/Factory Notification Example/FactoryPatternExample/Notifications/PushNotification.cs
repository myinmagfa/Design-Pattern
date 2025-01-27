using FactoryPatternExample.Logistic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Notifications
{
    public class PushNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Push Sent!");
        }
    }
}
