using CTTSite.DAO;
using CTTSite.Models;

namespace CTTSite.Services.Interface
{
    // Made by Mads
    public interface IOrderService
    {
        Task<List<Order>> GetAllOrdersAsync();
        Task CreateOrderAsync(Order order);
        Task CancelOrderByIDAsync(int ID);
        Task<List<Order>> GetOrdersByUserIDAsync(int userID);
        Task<Order> GetOrderByIDAsync(int ID);
        Task<List<CartItem>> GetOldOrderByOrderIDAsync(int ID);
        Task AddCartItemsToOrderAsync(int ID);
        Task<int> GetLatestOrderFromUserAsync(string userName);
        Task DeleteOrderByOrderIDAsync(int ID);
        Task UpdateOrderAsync(Order order);
        Task SubmitCancelOrderByEmailAsync(int ID, string email);
        Task<bool> IsOrderEmptyAsync(string userEmail);
    }
}
