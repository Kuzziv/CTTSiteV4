using CTTSite.Models;
using CTTSite.Services;
using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.Store.Product
{
    public class SpecificProductPageModel : PageModel
    {
        private readonly IItemService _itemService;
        private readonly ICartItemService _cartItemService;
        private readonly IUserService _userService;

        [BindProperty]
        public Item Item { get; set; }

        public CartItem CartItem { get; set; } = new CartItem();

        public Models.User User { get; set; }
        public string Message { get; set; }
        public string MessageColor { get; set; }

        [BindProperty]
        public int Count { get; set; }

        public SpecificProductPageModel(IItemService itemService, ICartItemService cartItemService, IUserService userService)
        {
            _itemService = itemService;
            _cartItemService = cartItemService;
            _userService = userService;
        }

        public async Task OnGetAsync(int ID)
        {
            Item = await _itemService.GetItemByIDAsync(ID);
        }

        public async Task<IActionResult> OnPostAsync(int ID)
        {
            Item = await _itemService.GetItemByIDAsync(ID);
            User = _userService.GetUserByEmail(HttpContext.User.Identity.Name);

            if (Count > Item.Stock)
            {
                MessageColor = "red";
                Message = $"There are only {Item.Stock} left in stock";
                return Page();
            }

            if (Count <= 0)
            {
                MessageColor = "red";
                Message = "There must be a valid amount";
                return Page();
            }

            if (Count <= Item.Stock)
            {
                MessageColor = "green";
                Message = $"{Item.Name} has been add to your cart";
            }

            CartItem.ItemID = ID;
            CartItem.Quantity = Count;
            CartItem.UserID = User.Id;
            CartItem.Paid = false;

            await _cartItemService.AddToCartAsync(CartItem);
            return Page();
        }
    }
}
