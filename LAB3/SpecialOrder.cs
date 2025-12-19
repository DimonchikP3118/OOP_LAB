using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class SpecialOrder : Order,IOrder
    {
        public SpecialOrder() { }
        public string predpochteniya;
        public SpecialOrder(int sum, List<Item> items, string predpochnteniya) : base(sum, items)
        {
            this.predpochteniya = predpochnteniya;
        }

        public void Deliver()
        {
            Console.WriteLine("Доставили заказ очень быстро и с персональными предпочтениями:");
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
