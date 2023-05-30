using CTTSite.Models;

namespace CTTSite.MockData
{
    // Made by Mille & Mads
    public class MockDataItem
    {
        public static List<Item> Items = new List<Item>() 
        { 
            new Item(1, "Gift Basket", "This gift basket is perfect for self-care.", "", 25, 15),
            new Item(2, "Scented candles", "These scented candles gives a lovely and relaxing aroma.", "", 10, 56),
            new Item(3, "The little book of hygge", "Great book to take with you everywhere for a quick read.", "", 29, 74),
            new Item(4, "Paint kit", "Cozy plaint kit to get your thoughts and emotions out on a canvas.", "", 12, 28),
        };

        public static List<Item> GetMockItem() { return Items; }
        
    }
}
