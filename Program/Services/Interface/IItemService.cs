using CTTSite.Models;

namespace CTTSite.Services
{
    public interface IItemService
    {
        Task<List<Item>> GetAllItemsAsync();
        Task CreateItemAsync(Item item);
        Task UpdateItemAsync(Item itemN);
        Task DeleteItemByIDAsync(int ID);
        Task UpdateItemStockAsync(int itemID, int amount);
        Task<Item> GetItemByIDAsync(int ID);
        Task UpdateItemQuantityByIDAsync(int itemID, int quantity);
    }
}
