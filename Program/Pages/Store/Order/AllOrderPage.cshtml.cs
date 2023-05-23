using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace CTTSite.Pages.Store.Order
{
    [Authorize(Roles = "admin")]
    public class AllOrderPageModel : PageModel
    {
        private readonly IOrderService _orderService;
        public List<Models.Order> Orders;

        public AllOrderPageModel(IOrderService iOrderService)
        {
            _orderService = iOrderService;
        }

        public async Task OnGetAsync()
        {
            Orders = await _orderService.GetAllOrdersAsync();
        }
    }
}
