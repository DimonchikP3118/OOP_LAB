using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class SpecialOrderBuilder : OrderBuilder
    {
        private SpecialOrder Order = new SpecialOrder();

        public Order GetResult()
        {
            return Order;
        }
        public void MakeItems()
        {
            List<Item> It = new List<Item>
            {
                new Item("Курица гриль", "Мясо", "Россия", 800),
                new Item("Салат Цезарь", "Салаты", "Италия", 350),
                new Item("Пицца Маргарита", "Пицца", "Италия", 1200),
                new Item("Бургер классический", "Фастфуд", "США", 450),
                new Item("Ролл Филадельфия", "Суши", "Япония", 280)
            };
            List<Item> itemyt = new List<Item>();
            string f = "Y";
            while (f == "Y")
            {
                if (It.Count == 0) 
                {
                    Console.WriteLine("Товаров больше нет");
                    Order.Items = itemyt;
                    return;
                }
                Console.WriteLine("Список продуктов:");
                foreach (Item item in It)
                {
                    Console.WriteLine(item.name + " - " + item.weight);
                }
                Console.WriteLine("Выберите из списка предмет и напишите его название:");
                string ch = Console.ReadLine();
                foreach(Item item in It)
                {
                    if(item.name == ch)
                    {
                        itemyt.Add(item);
                        It.Remove(item);
                        Console.WriteLine("Добавлен новый предмет в корзину");
                        break;
                    }
                }
                Console.WriteLine("Если хотите продолжить выбирать товары - нажмите 'Y', если нет - нажмите любую другую клавишу");
                ch = Console.ReadLine();
                if (ch != "Y")
                {
                    Order.Items = itemyt;
                    return;
                }
            }
        }

        //public void MakeItems()
        //{
        //    Order.Items = new List<Item>
        //    {
        //        new Item("Курица гриль", "Мясо", "Россия", 800),
        //        new Item("Салат Цезарь", "Салаты", "Италия", 350),
        //        new Item("Пицца Маргарита", "Пицца", "Италия", 1200),
        //        new Item("Бургер классический", "Фастфуд", "США", 450),
        //        new Item("Ролл Филадельфия", "Суши", "Япония", 280) 
        //    };
        //}

        public void Reset()
        {
           Order = new SpecialOrder(); 
        }

        public void setSum()
        {
            int s = 0;
            foreach(Item item in Order.Items)
            {
                s += item.weight;
            }
            Order.sum = s;
        }
        
    }
}
