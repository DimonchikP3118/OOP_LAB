using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class PaymentContext
    {
        private IPayment payment;
        public PaymentContext(IPayment payment)
        {
            this.payment = payment;
        }
        public void Setpayment(IPayment payment)
        {
            this.payment = payment;
        }
        public void MakePayment(decimal sum)
        {
            payment.Payit(sum);
        }
    }
}
