using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public interface IState
    {
        bool CanAddItems();
        bool CanCancel();
        bool CanComplete();
        public string Description { get; }
    }
}
