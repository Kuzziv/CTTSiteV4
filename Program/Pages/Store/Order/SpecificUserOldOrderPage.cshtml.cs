using CTTSite.Models;
using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.Store.Order
{
    // Made by Mads
    public class SpecificUserOldOrderPageModel : PageModel
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;

        [BindProperty]
        public Models.Order Order { get; set; }
        public decimal TotalPrice { get; set; }
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();

        public SpecificUserOldOrderPageModel(IUserService userService, IOrderService orderService)
        {
            _userService = userService;
            _orderService = orderService;
        }


        public async Task<IActionResult> OnGetAsync(int ID)
        {
            Models.User CurrentUser = _userService.GetUserByEmail(HttpContext.User.Identity.Name);
            Order = await _orderService.GetOrderByIDAsync(ID);
            CartItems = await _orderService.GetOldOrderByOrderIDAsync(ID);
            TotalPrice = Order.TotalPrice;
            return Page();
        }
    }
}
