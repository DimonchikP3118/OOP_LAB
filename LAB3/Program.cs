using System;
using LAB3;

class Programm
{
    static void Main(String[] args)
    {
        var manager = DeliveryOrder.Instance;
        manager.start();
    }
}
