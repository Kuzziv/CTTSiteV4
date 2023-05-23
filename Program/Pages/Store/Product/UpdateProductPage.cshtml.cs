using CTTSite.Models;
using CTTSite.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace CTTSite.Pages.Store.Product
{
    [Authorize(Roles = "admin")]
    public class UpdateProductPageModel : PageModel
    {
        private readonly IItemService _itemService;

        [BindProperty]
        public Item Item { get; set; }

        public UpdateProductPageModel(IItemService itemService)
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
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _itemService.UpdateItemAsync(Item);
            return RedirectToPage("AdminProductsPage");
        }
    }
}
