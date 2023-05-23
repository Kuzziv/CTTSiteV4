using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace CTTSite.Pages.Store.Order
{
    [Authorize(Roles = "admin")]
    public class DeleteOrderPageModel : PageModel
    {
        private readonly IOrderService _orderService;

        [BindProperty]
        public Models.Order Order { get; set; } 

        public DeleteOrderPageModel(IOrderService orderService)
        {
            _orderService = orderService;
        }


        public async Task OnGetAsync(int ID)
        {
            Order = await _orderService.GetOrderByIDAsync(ID);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _orderService.DeleteOrderByOrderIDAsync(Order.ID);
            return RedirectToPage("/Store/Order/AllOrderPage");
        }
    }
}
