using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.Store.Order
{
    // Made by Mille & Mads
    public class OrderConfirmationPageModel : PageModel
    {
        private readonly IOrderService _orderService;
        public int OrderID { get; set; }

        public OrderConfirmationPageModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task OnGetAsync()
        {
            OrderID = await _orderService.GetLatestOrderFromUserAsync(User.Identity.Name);
        }
    }
}
