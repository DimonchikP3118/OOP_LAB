using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LAB3
{
    public sealed class DeliveryOrder
    {
        private static DeliveryOrder instance;
        public List<Order> orders;
        private Employee employee;
        private DeliveryOrder()
        {
            orders = new List<Order>();
        }
        public static DeliveryOrder Instance
        {
                get
                { 
                    {
                        if (instance == null)  
                        {
                            instance = new DeliveryOrder();
                        }
                    }
                return instance;
                }
            }
        public void start()
        {
            while (true)
            {
                makeCom();
                string com = Console.ReadLine();
                switch (com)
                {
                    case "1": MakeSimpleOrder(); break;
                    case "2": MakeVIPOrder(); break;
                    case "3": PrintOrders(); break;
                }
            }
        }
        private void makeCom()
        {
            Console.WriteLine("1 - Создать заказ");
            Console.WriteLine("2 - Создать заказ с предпочтениями");
            Console.WriteLine("3 - Вывести историю заказов");
        }
        private void MakeSimpleOrder()
        {
            var payment = new PaymentContext(new CardPayment());
            employee = new Employee();
            var builder = new SpecialOrderBuilder();
            employee.makeFullOrder(builder);
            Order order = builder.GetResult();
            Console.WriteLine("Ваша скидка составила - 5%" + "\nПлата за доставку - 100" + "\nНалог - 15%");
            int buff = 100 - (order.getSum() / 20) + (order.getSum() / 6);
            order.plusSum(buff);
            order.getFullInfo();
            Console.WriteLine("Выберите способ оплаты: \n1 - картой\n2 - СБП\n3 - крипта");
            string opl = Console.ReadLine();
            if(opl == "3")
            {
                payment.Setpayment(new CryptoPayment());
            }
            else if(opl == "2") 
            {
                payment.Setpayment(new SBPPayment());
                
            }
            payment.MakePayment(order.getSum());
            orders.Add(order);
            Console.WriteLine("Вы создали заказ и теперь он у вас в истории заказов");
            order.setState(new DeliveringState());
            order.getState();
            Logistic logistic = new SimpleLogistic();
            logistic.SendDelivery();
        }
        private void MakeVIPOrder()
        {
            var payment = new PaymentContext(new CardPayment());
            employee = new Employee();
            var builder = new SpecialOrderBuilder();
            employee.makeFullOrder(builder);
            Order order = builder.GetResult();
            Console.WriteLine("Ваша скидка составила - 5%" + "\nПлата за доставку - 100" + "\nНалог - 15%");
            int buff = 100 - (order.getSum() / 20) + (order.getSum() / 6);
            order.plusSum(buff);
            order.getFullInfo();
            orders.Add(order);
            Console.WriteLine("Вы создали заказ и теперь он у вас в истории заказов");
            Console.WriteLine("Напишите ваши предпочтения:");
            string pred = Console.ReadLine();
            order.setState(new DeliveringState());
            order.getState();
            Logistic logistic = new VIPLogistic();
            logistic.SendDelivery();
            Console.WriteLine(pred);
        }
        private void PrintOrders()
        {
            Console.WriteLine("Список заказов");
            foreach (var order in orders)
            {
                Console.WriteLine("-----------------------------");
                order.getFullInfo();
            }
        }
    }
} 
    

