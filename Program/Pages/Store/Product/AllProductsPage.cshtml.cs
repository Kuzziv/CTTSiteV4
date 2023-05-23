using CTTSite.Models;
using CTTSite.Services;
using CTTSite.Services.NormalService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CTTSite.Pages.Store.Product
{
    public class AllProductsPageModel : PageModel
    {
        private readonly IItemService _itemService;
        public List<Item> Items;
        
        public AllProductsPageModel(IItemService itemService)
        {
            _itemService = itemService;
        }

        public async Task OnGetAsync()
        {
            Items = await _itemService.GetAllItemsAsync();
        }
    }
}
