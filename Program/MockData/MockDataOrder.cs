using CTTSite.Models;

namespace CTTSite.MockData
{
    public class MockDataOrder
    {
        public static List<Order> Orders = new List<Order>()
        {
            new Order(1, 2, 56, true, false),
            new Order(2, 2, 82, false, true),
            new Order(3, 2, 23, true, true),
            new Order(4, 2, 64, true, false),
        };

        public static List<Order> GetMockOrders() { return Orders; }
    }
}
