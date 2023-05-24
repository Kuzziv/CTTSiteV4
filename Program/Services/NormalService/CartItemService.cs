using CTTSite.DAO;
using CTTSite.EFDbContext;
using CTTSite.MockData;
using CTTSite.Models;
using CTTSite.Services.DB;
using CTTSite.Services.Interface;
using CTTSite.Services.JSON;
using Microsoft.EntityFrameworkCore;

namespace CTTSite.Services.NormalService
{
    public class CartItemService : ICartItemService
    {
        private readonly DBServiceGeneric<CartItem> _dBServiceGenericCartItem;
        private readonly JsonFileService<CartItem> _jsonFileService;
        private readonly IItemService _itemService;
        private readonly IUserService _userService;
        private List<CartItem> _cartItems { get; set; }
        private List<Item> _items { get; set; }

        public CartItemService(DBServiceGeneric<CartItem> dBServiceGenericCartItem, JsonFileService<CartItem> jsonFileService, IItemService itemService, IUserService userService)
        {
            _dBServiceGenericCartItem = dBServiceGenericCartItem;
            _jsonFileService = jsonFileService;
            _itemService = itemService;
            _userService = userService;
            _cartItems = GetAllCartItemsAsync().Result;
            _items = _itemService.GetAllItemsAsync().GetAwaiter().GetResult();
        }

        public async Task<bool> IsCartEmptyAsync(string userEmail)
        {
            User user = _userService.GetUserByEmail(userEmail);
            List<CartItem> cartItemsList = await GetAllCartItemsByUserIDAsync(user.Id);
            if (cartItemsList.Count == 0)
            {
                return true;
            }
            else 
            { 
                return false; 
            }

        }

        public async Task<List<CartItem>> GetAllCartItemsAsync()
        {
            //return MockData.MockDataCartItem.GetMockCartItems();
            //return _jsonFileService.GetJsonObjects().ToList();
            return (await _dBServiceGenericCartItem.GetObjectsAsync()).ToList();
        }

        public async Task AddToCartAsync(CartItem cartItem)
        {
            //int IDCount = 0;
            //foreach(CartItem listCartItem in CartItems)
            //{
            //    if(IDCount < listCartItem.ID)
            //    {
            //        IDCount = listCartItem.ID;
            //    }
            //}
            //cartItem.ID = IDCount + 1;
            _cartItems.Add(cartItem);
            //_jsonFileService.SaveJsonObjects(CartItems);
            await _dBServiceGenericCartItem.AddObjectAsync(cartItem);
        }

        public async Task ConvertBoolPaidByUserIDAsync(int userID)
        {
            List<CartItem> cartItems = await GetAllCartItemsByUserIDAsync(userID);

            foreach (CartItem cartItem in cartItems)
            {
                cartItem.Paid = true;
                await _dBServiceGenericCartItem.UpdateObjectAsync(cartItem);
            }

            //_jsonFileService.SaveJsonObjects(CartItems);
        }

        public async Task<CartItem> GetCartItemByIDAsync(int ID)
        {
            using (ItemDbContext context = new ItemDbContext())
            {
                return await context.CartItems
                    .Include(ci => ci.Item)
                    .FirstOrDefaultAsync((CartItem cartItem) => cartItem.ID == ID);
            }
        }

        public async Task<List<CartItem>> GetAllCartItemsByUserIDAsync(int userID)
        {
            List<CartItem> cartItemsByUserID = new List<CartItem>();
            using (ItemDbContext context = new ItemDbContext())
            {
                List<CartItem> cartItems = await context.CartItems
                    .Include(ci => ci.Item)
                    .Where((CartItem ci) => ci.UserID == userID && !ci.Paid)
                    .ToListAsync();

                cartItemsByUserID.AddRange(cartItems);
            }
            return cartItemsByUserID;
        }


        public async Task RemoveFromCartByIDAsync(int ID)
        {
            CartItem cartItemToBeDeleted = await GetCartItemByIDAsync(ID);

            if (cartItemToBeDeleted != null)
            {
                _cartItems.Remove(cartItemToBeDeleted);
                //_jsonFileService.SaveJsonObjects(CartItems);
                await _dBServiceGenericCartItem.DeleteObjectAsync(cartItemToBeDeleted);
            }
        }

        public async Task<decimal> GetTotalPriceOfCartByUserIDAsync(int userID)
        {
            decimal totalPrice = 0;
            List<CartItem> cartItems = await GetAllCartItemsByUserIDAsync(userID);
            List<Item> items = await _itemService.GetAllItemsAsync();

            foreach (CartItem cartItem in cartItems)
            {
                Item item = items.FirstOrDefault(i => i.ID == cartItem.ItemID);
                if (item != null)
                {
                    totalPrice += item.Price * cartItem.Quantity;
                }
            }

            return totalPrice;
        }

    }
}
