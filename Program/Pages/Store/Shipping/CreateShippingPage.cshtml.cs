using CTTSite.Models;
using CTTSite.Services;
using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.Store.Shipping
{
    public class CreateShippingPageModel : PageModel
    {
        private readonly IShippingInfoService _shippingInfoService;
        private readonly IOrderService _orderService;
        private readonly IItemService _itemService;
        private readonly ICartItemService _cartItemService;
        private readonly IUserService _userService;

        [BindProperty]
        public ShippingInfo ShippingInfo { get; set; } = new ShippingInfo();

        [BindProperty]
        public Models.Order Order { get; set; } = new Models.Order();

        public List<CartItem> CartItems { get; set; } = new List<CartItem>();

        public CreateShippingPageModel(IShippingInfoService shippingInfoService, IOrderService orderService, IItemService itemService, ICartItemService cartItemService, IUserService userService)
        {
            _cartItemService = cartItemService;
            _shippingInfoService = shippingInfoService;
            _orderService = orderService;
            _itemService = itemService;
            _userService = userService;
        }

        public async Task OnGetAsync()
        {
            Models.User currentUser = _userService.GetUserByEmail(HttpContext.User.Identity.Name);
            CartItems = await _cartItemService.GetAllCartItemsByUserIDAsync(currentUser.Id);
        }


        public async Task<IActionResult> OnPostCreateOrderAsync()
        {
            Models.User currentUser = _userService.GetUserByEmail(HttpContext.User.Identity.Name);
            CartItems = await _cartItemService.GetAllCartItemsByUserIDAsync(currentUser.Id);
            ShippingInfo.UserID = currentUser.Id;
            ShippingInfo.SubmissionDate = DateTime.Now;
            Order.UserID = currentUser.Id;
            Order.Shipped = false;
            Order.Cancelled = false;
            Order.TotalPrice = await _cartItemService.GetTotalPriceOfCartByUserIDAsync(currentUser.Id);
            await _orderService.CreateOrderAsync(Order);
            ShippingInfo.OrderID = Order.ID;
            await _shippingInfoService.CreateShippingInfoAsync(ShippingInfo);
            if (CartItems != null)
            {
                foreach (CartItem cartItem in CartItems)
                {
                    await _itemService.UpdateItemQuantityByIDAsync(cartItem.ItemID, cartItem.Quantity);
                }
            }
            await _shippingInfoService.SubmitShippingInfoByEmailAsync(ShippingInfo, currentUser.Email);
            await _orderService.AddCartItemsToOrderAsync(currentUser.Id);
            await _cartItemService.ConvertBoolPaidByUserIDAsync(currentUser.Id);
            return RedirectToPage("/Store/Order/OrderConfirmationPage");
        }
    }
}
