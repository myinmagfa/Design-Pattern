using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Logistic
{
    public abstract class Creator
    {
        public abstract INotification FactoryMethod();

        public void Logic()
        {
            var notification = FactoryMethod();
            notification.Send();
        }
    }
}
