using CTTSite.Models;
using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.Store.Cart
{
    public class SpecificUserCartPageModel : PageModel
    {
        private readonly ICartItemService _cartItemService;
        private readonly IUserService _userService;

        [BindProperty]
        public List<CartItem> CartItems { get; set; }
        public int CartItemsCount { get; set; }
        public decimal TotalPrice { get; set; }

        public SpecificUserCartPageModel(ICartItemService cartItemService, IUserService userService)
        {
            _cartItemService = cartItemService;
            _userService = userService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Models.User currentUser = _userService.GetUserByEmail(HttpContext.User.Identity.Name);
            CartItems = await _cartItemService.GetAllCartItemsByUserIDAsync(currentUser.Id);
            TotalPrice = await _cartItemService.GetTotalPriceOfCartByUserIDAsync(currentUser.Id);
            CartItemsCount = CartItems.Count;
            return Page();
        }
    }
}
