using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class SimpleLogistic : Logistic
    {
        public override IOrder CreateOrder() => new ClassicOrder();
        
    }
}
