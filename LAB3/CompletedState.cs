using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class CompletedState : IState
    {
        public string Description => "Ваш заказ доставлен";

        public bool CanAddItems() => false;
        public bool CanCancel() => false;
        public bool CanComplete() => false;
    }
}
