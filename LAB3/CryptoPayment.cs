using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class CryptoPayment : IPayment
    {
        public void Payit(decimal sum)
        {
           Console.WriteLine("Вы оплатили криптой покупку на сумму - " + sum);
        }
    }
}
