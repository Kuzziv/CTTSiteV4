using CTTSite.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace CTTSite.Pages.Store.Product
{
    // Made by Mille & Mads
    [Authorize(Roles = "admin")]
    public class DeleteProductPageModel : PageModel
    {
        private readonly IItemService _itemService;

        [BindProperty]
        public Models.Item Item { get; set; }

        public DeleteProductPageModel(IItemService itemService)
        {
            _itemService = itemService;
        }

        public async Task OnGetAsync(int ID)
        {
            Item = await _itemService.GetItemByIDAsync(ID);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _itemService.DeleteItemByIDAsync(Item.ID);
            return RedirectToPage("AdminProductsPage");
        }
    }
}
