using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class SBPPayment : IPayment
    {
        public void Payit(decimal sum)
        {
           Console.WriteLine("Вы успешно оплатили покупку по СБП на сумму - " + sum);
        }
    }
}
