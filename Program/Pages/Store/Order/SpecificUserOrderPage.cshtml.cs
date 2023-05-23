using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.Store.Order
{
    public class SpecificUserOrderPageModel : PageModel
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;

        public List<Models.Order> Orders { get; set; }

        public SpecificUserOrderPageModel(IOrderService orderService, IUserService userService)
        {
            _orderService = orderService;
            _userService = userService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Models.User CurrentUser = _userService.GetUserByEmail(HttpContext.User.Identity.Name);
            Orders = await _orderService.GetOrdersByUserIDAsync(CurrentUser.Id);
            return Page();
        }
    }
}
