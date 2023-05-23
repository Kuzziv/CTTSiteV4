using CTTSite.Models;

namespace CTTSite.MockData
{
    public class MockDataShippingInfo
    {
        public static List<ShippingInfo> shippingInfos = new List<ShippingInfo>()
        {
            new ShippingInfo(2, 1, "JumpStreet 69", "Birmingham", "B11JS69", "Birmingham", "12345678901", "Patrick", "Star", DateTime.UtcNow),
            new ShippingInfo(2, 2,"BikiniBottom 02", "Birmingham", "B11BB02", "Birmingham", "84267394272", "Bob", "Sponge", DateTime.UtcNow),
            new ShippingInfo(2, 3,"CowBoyStreet 14", "Leicester", "LE1CBS14", "Leicester", "94979459849", "Katie", "Perry", DateTime.UtcNow),
            new ShippingInfo(2, 4,"StarRail 101", "London", "E17AXSR101", "London", "11010100100", "Bean", "Mister", DateTime.UtcNow),
        };

        public static List<ShippingInfo> GetMockShippingInfos()
        {
            return shippingInfos;
        }

    }
}
