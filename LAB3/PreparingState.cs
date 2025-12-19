using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class PreparingState : IState
    {
        public string Description => "Начали готовить заказ";

        public bool CanAddItems() => false;
        public bool CanCancel() => true;
        public bool CanComplete() => false;
    }
}
