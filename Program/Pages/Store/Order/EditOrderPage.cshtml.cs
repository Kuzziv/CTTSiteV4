using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace CTTSite.Pages.Store.Order
{
    // Made by Mads
    [Authorize(Roles = "admin")]
    public class EditOrderPageModel : PageModel
    {
        private readonly IOrderService _orderService;

        [BindProperty]
        public Models.Order Order { get; set; }

        public EditOrderPageModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task OnGetAsync(int ID)
        {
            Order = await _orderService.GetOrderByIDAsync(ID);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _orderService.UpdateOrderAsync(Order);
            return RedirectToPage("/Store/Order/AllOrderPage");
        }
    }
}
