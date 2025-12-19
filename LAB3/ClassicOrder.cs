using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class ClassicOrder : Order, IOrder
    {
        public ClassicOrder() { }
        public ClassicOrder(int sum, List<Item> items) : base(sum, items)
        {
        }

        public void Deliver()
        {
            Console.WriteLine("Ваш заказ доставлен");
            setState(new CompletedState());
        }

        public override void getFullInfo()
        {
            Console.WriteLine("Список продуктов:");
            foreach (var Item in Items)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(Item.GetInfo());
            }
            Console.WriteLine("Сумма - " + sum);
        }
    }
}
