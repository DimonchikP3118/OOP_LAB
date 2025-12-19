using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class CreateState :IState
    {
        public string Description => "Составление заказа";

        public bool CanAddItems() => true;
        public bool CanCancel() => true;
        public bool CanComplete() => false;
    }
}
