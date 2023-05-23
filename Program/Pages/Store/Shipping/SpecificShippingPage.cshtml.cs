using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.Store.Shipping
{
    public class SpecificShippingPageModel : PageModel
    {
        private readonly IShippingInfoService _shippingInfoService;

        [BindProperty]
        public Models.ShippingInfo ShippingInfo { get; set; }

        public SpecificShippingPageModel(IShippingInfoService shippingInfoService)
        {
            _shippingInfoService = shippingInfoService;
        }

        public async Task OnGetAsync(int ID)
        {
            ShippingInfo = await _shippingInfoService.GetShippingByOrderIDAsync(ID);
        }
    }
}
