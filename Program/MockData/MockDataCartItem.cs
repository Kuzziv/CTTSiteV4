using CTTSite.Models;

namespace CTTSite.MockData
{
    public class MockDataCartItem
    {
        public static List<CartItem> cartItems = new List<CartItem>()
        {
            //new CartItem(1, 2, 5, 3, false),
            //new CartItem(2, 3, 1, 3, false),
            //new CartItem(3, 5, 2, 3, false),
            //new CartItem(4, 1, 8, 3, false),
        };

        public static List<CartItem> GetMockCartItems()
        {
            return cartItems;
        }
    }
}
