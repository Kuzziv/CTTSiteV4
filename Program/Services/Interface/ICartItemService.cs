using CTTSite.Models;

namespace CTTSite.Services.Interface
{
    public interface ICartItemService
    {
        Task<List<CartItem>> GetAllCartItemsAsync();
        Task<List<CartItem>> GetAllCartItemsByUserIDAsync(int userID);
        Task AddToCartAsync(CartItem cartItem);
        Task RemoveFromCartByIDAsync(int ID);
        Task ConvertBoolPaidByUserIDAsync(int userID);
        Task<CartItem> GetCartItemByIDAsync(int ID);
        Task<decimal> GetTotalPriceOfCartByUserIDAsync(int userID);
        Task<bool> IsCartEmptyAsync(string userName);
    }
}
