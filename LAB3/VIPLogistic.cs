using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class VIPLogistic : Logistic
    {
        public override IOrder CreateOrder() => new SpecialOrder();
        
    }
}
