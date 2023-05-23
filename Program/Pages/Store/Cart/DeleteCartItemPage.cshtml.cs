using CTTSite.Models;
using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.Store.Cart
{
    public class DeleteCartItemPageModel : PageModel
    {
        private readonly ICartItemService _cartItemService;
        private readonly IUserService _userService;

        [BindProperty]
        public CartItem CartItem { get; set; }

        public DeleteCartItemPageModel(ICartItemService cartItemService, IUserService userService)
        {
            _cartItemService = cartItemService;
            _userService = userService;
        }
        public async Task OnGetAsync(int ID)
        {
            CartItem = await _cartItemService.GetCartItemByIDAsync(ID);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _cartItemService.RemoveFromCartByIDAsync(CartItem.ID);
            return RedirectToPage("SpecificUserCartPage");
        }
    }
}
