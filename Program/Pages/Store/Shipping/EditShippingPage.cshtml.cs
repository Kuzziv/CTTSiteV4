using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace CTTSite.Pages.Store.Shipping
{
    [Authorize(Roles = "admin")]
    public class EditShippingPageModel : PageModel
    {
        private readonly IShippingInfoService _shippingInfoService;
        [BindProperty]
        public Models.ShippingInfo ShippingInfo { get; set; }

        public EditShippingPageModel(IShippingInfoService shippingInfoService)
        {
            _shippingInfoService = shippingInfoService;
        }

        public async Task OnGetAsync(int ID)
        {
            ShippingInfo = await _shippingInfoService.GetShippingByOrderIDAsync(ID);
        }

        public async Task<IActionResult> OnPostAsync(int ID)
        {
            await _shippingInfoService.UpdateShippingAsync(ShippingInfo);
            return RedirectToPage("/Store/Order/AllOrderPage");
        }

    }
}
