using FactoryPatternExample.Logistic;
using FactoryPatternExample.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Creators
{
    public class EmailNotificationCreator : Creator
    {
        public override INotification FactoryMethod()
        {
            return new EmailNotification();
        }
    }
}
