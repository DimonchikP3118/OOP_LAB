using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public interface OrderBuilder
    {
        public void Reset();
        public void setSum();
        public void MakeItems();
        public Order GetResult();
        
    }
}
