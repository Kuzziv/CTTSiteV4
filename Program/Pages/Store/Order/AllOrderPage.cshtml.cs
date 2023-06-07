using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace CTTSite.Pages.Store.Order
{
    // Made by Mille & Mads
    [Authorize(Roles = "admin")]
    public class AllOrderPageModel : PageModel
    {
        private readonly IOrderService _orderService;
        public List<Models.Order> Orders;

        [BindProperty]
        public string SearchString { get; set; }

        public AllOrderPageModel(IOrderService iOrderService)
        {
            _orderService = iOrderService;
        }

        public async Task<IActionResult> OnPostSearchOrderAsync()
        {
            Orders = await _orderService.GetOrdersByIDAsync(SearchString);
            return Page();
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Orders = await _orderService.GetAllOrdersAsync();
            return Page();
        }

        public async Task<IActionResult> OnGetAllAsync()
        {
            Orders = await _orderService.GetAllOrdersAsync();
            return Page();
        }

        public async Task<IActionResult> OnGetUnShippedAsync()
        {
            Orders = await _orderService.GetAllUnShippedOrdersAsync();
            return Page();
        }
    }
}
