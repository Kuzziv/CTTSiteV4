using CTTSite.MockData;
using CTTSite.Models;
using CTTSite.Services.DB;
using CTTSite.Services.JSON;

namespace CTTSite.Services.NormalService
{
    public class ItemService : IItemService
    {
        private readonly DBServiceGeneric<Item> _dBServiceGeneric;
        private readonly JsonFileService<Item> _jsonFileService;
        private List<Item> _items { get; set; }

        public ItemService(DBServiceGeneric<Item> dBServiceGeneric, JsonFileService<Item> jsonFileService)
        {
            _dBServiceGeneric = dBServiceGeneric;
            _jsonFileService = jsonFileService;
            _items = GetAllItemsAsync().Result;
        }

        public async Task<List<Item>> GetAllItemsAsync()
        {
            return (await _dBServiceGeneric.GetObjectsAsync()).ToList();
            //return _jsonFileService.GetJsonObjects().ToList();
            //return MockData.MockDataItem.GetMockItem();
        }

        public async Task CreateItemAsync(Item item)
        {
            //int IDCount = 0;
            //foreach(Item listItem in Items)
            //{
            //    if(IDCount < listItem.ID)
            //    {
            //        IDCount = listItem.ID;
            //    }
            //}
            //item.ID = IDCount + 1;
            _items.Add(item);
            //_jsonFileService.SaveJsonObjects(Items);
            await _dBServiceGeneric.AddObjectAsync(item);
        }

        public async Task DeleteItemByIDAsync(int ID)
        {
            Item itemToBeDeleted = await GetItemByIDAsync(ID);
            if (itemToBeDeleted != null)
            {
                _items.Remove(itemToBeDeleted);
                _jsonFileService.SaveJsonObjects(_items);
                await _dBServiceGeneric.DeleteObjectAsync(itemToBeDeleted);
            }
        }

        public async Task UpdateItemAsync(Item itemN)
        {
            if(itemN != null) 
            { 
                foreach(Item itemO in _items) 
                { 
                    if(itemO.ID == itemN.ID)
                    {
                        itemO.Name = itemN.Name;
                        itemO.Description = itemN.Description;
                        itemO.Price = itemN.Price;
                        itemO.Stock = itemN.Stock;
                        itemO.IMG = itemN.IMG;
                        //_jsonFileService.SaveJsonObjects(Items);
                        await _dBServiceGeneric.UpdateObjectAsync(itemO);
                    }
                }
            }
        }

        public async Task<Item> GetItemByIDAsync(int ID) 
        { 
            //foreach(Item item in Items)
            //{
            //    if(item.ID == ID)
            //    {
            //        return item;
            //    }
            //}
            //return null;

            return await _dBServiceGeneric.GetObjectByIdAsync(ID);
        }

        public async Task UpdateItemStockAsync(int itemID, int amount)
        {
            Item item = await GetItemByIDAsync(itemID);
            if (item != null)
            {
                if (amount != null)
                {
                    item.Stock = item.Stock + amount;
                    //_jsonFileService.SaveJsonObjects(Items);
                    await _dBServiceGeneric.UpdateObjectAsync(item);
                }
            }
        }

        public async Task UpdateItemQuantityByIDAsync(int itemID, int quantity)
        {
            Item item = await GetItemByIDAsync(itemID);
            if (item != null)
            {
                item.Stock = item.Stock - quantity;
                //_jsonFileService.SaveJsonObjects(Items);
                await _dBServiceGeneric.UpdateObjectAsync(item);
            }
        }

    }
}
