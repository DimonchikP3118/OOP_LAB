using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class DeliveringState : IState
    {
        public string Description => "Курьер едет к вам";

        public bool CanAddItems() => false;
        public bool CanCancel() => false;
        public bool CanComplete() => true;
    }
}
