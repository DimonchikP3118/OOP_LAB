using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public abstract class Order
    {
        public Order() { }
        public List<Item> Items;
        public int sum;
        public IState state;

        public Order(int sum, List<Item> items) 
        {
            this.sum = sum;
            this.Items = items;
            state = new CreateState();
        }
        public void getState()
        {
            Console.WriteLine("Статус заказа - " + state.Description);
        }
        public void setState(IState state) 
        {
            this.state = state;
        }

        public abstract void getFullInfo();
        public void setSum(int sum) { this.sum = sum; }
        public int getSum() { return sum; }
        public void plusSum(int value) { this.sum = sum + value; }

    }
}
