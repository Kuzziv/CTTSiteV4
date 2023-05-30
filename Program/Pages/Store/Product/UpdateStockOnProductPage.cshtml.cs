using CTTSite.Models;
using CTTSite.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace CTTSite.Pages.Store.Product
{
    // Made by Mads
    [Authorize(Roles = "admin")]
    public class UpdateStockOnProductPageModel : PageModel
    {
        private readonly IItemService _itemService;

        [BindProperty]
        public Item Item { get; set; }
        [BindProperty]
        public int count { get; set; }

        public UpdateStockOnProductPageModel(IItemService itemService)
        {
            _itemService = itemService;
        }

        public async Task<IActionResult> OnGetAsync(int ID)
        {
            Item = await _itemService.GetItemByIDAsync(ID);
            if (Item == null)
            {
                return RedirectToPage("AdminProductsPage");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _itemService.UpdateItemStockAsync(Item.ID, count);
            return RedirectToPage("AdminProductsPage");
        }
    }
}
