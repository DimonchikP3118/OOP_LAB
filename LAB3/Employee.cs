using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Employee
    {
        public void makeFullOrder(OrderBuilder builder)
        {
            builder.Reset();
            builder.MakeItems();
            builder.setSum();
            
        }
        public void makeEmptyOrder(OrderBuilder builder) 
        {
            builder.Reset();
            builder.setSum();
        }
    }
}
