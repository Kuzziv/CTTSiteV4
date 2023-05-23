using CTTSite.Models;

namespace CTTSite.Services.Interface
{
    public interface IShippingInfoService
    {
        Task CreateShippingInfoAsync(ShippingInfo shippingInfo);
        Task<ShippingInfo> GetShippingByIDAsync(int ID);
        Task<ShippingInfo> GetShippingByOrderIDAsync(int ID);
        Task DeleteShippingInfoByOrderIDAsync(int ID);
        Task UpdateShippingAsync(ShippingInfo shippingInfo);
        Task SubmitShippingInfoByEmailAsync(ShippingInfo shippingInfo, string email);
    }
}
