using CTTSite.Services.NormalService;
using CTTSite.Services;

namespace UnitTester
{
    [TestClass]
    public class Tester1
    {
        private IItemService _itemService;
        [TestInitialize]
        public void Initialize()
        {
            _itemService = new ItemService();

        }
        [TestMethod]
        public void Test_GetAllItem()
        {
            var count = _itemService.GetAllItemsAsync().Result.Count();

            //Assert
            Assert.IsTrue(count > 0);
        }
        [TestMethod]
        public void Test_GetItemByID()
        {
            var item = _itemService.GetItemByIDAsync(1).Result;
            //Assert
            Assert.IsTrue(item != null);
        }
    }
}