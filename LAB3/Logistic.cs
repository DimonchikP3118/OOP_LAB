using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public abstract class Logistic
    {
        
        public abstract IOrder CreateOrder();

        public void SendDelivery()
        {
            var order = CreateOrder();
            order.Deliver();
        }
    }
}
