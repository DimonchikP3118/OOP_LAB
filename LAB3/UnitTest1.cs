
using LAB3;

namespace Tests

{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var item = new Item("Пицца", "Еда", "Италия", 500);
            
            var info = item.GetInfo();
           
            Assert.Contains("Пицца", info);
            Assert.Contains("Еда", info);
            Assert.Contains("Италия", info);
            Assert.Contains("500", info);
        }
        [Fact]
        public void Test2()
        {  
            var items = new List<Item> { new Item("Товар", "Категория", "Страна", 100) };
            var order = new ClassicOrder(500, items); 
           
            order.setSum(1000);
           
            Assert.Equal(1000, order.getSum());
        }
        [Fact]
        public void Test3()
        {
            var items = new List<Item> { new Item("Товар", "Категория", "Страна", 100) };
            var order = new ClassicOrder(500, items);

            order.plusSum(300);

            Assert.Equal(800, order.getSum());
        }
        [Fact]
        public void Test4()
        {
            var deliveryOrder = DeliveryOrder.Instance;
            var initialCount = deliveryOrder.orders.Count;

            var items = new List<Item> { new Item("Тест", "Тест", "Тест", 100) };
            var testOrder = new ClassicOrder(500, items);

            deliveryOrder.orders.Add(testOrder);

            Assert.Equal(initialCount + 1, deliveryOrder.orders.Count);
        }
    }
}
