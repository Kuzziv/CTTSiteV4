using CTTSite.EFDbContext;
using CTTSite.Models;
using CTTSite.Services.DB;
using CTTSite.Services.Interface;
using CTTSite.Services.JSON;
using Microsoft.EntityFrameworkCore;

namespace CTTSite.Services.NormalService
{
    public class ShippingInfoService : IShippingInfoService
    {
        private readonly JsonFileService<ShippingInfo> _jsonFileService;
        private readonly DBServiceGeneric<ShippingInfo> _dBServiceGeneric;
        private readonly IEmailService _emailService;
        private List<ShippingInfo> _shippingInfoList;

        public ShippingInfoService(JsonFileService<ShippingInfo> jsonFileService, DBServiceGeneric<ShippingInfo> dBServiceGeneric, IEmailService emailService)
        {
            _jsonFileService = jsonFileService;
            _dBServiceGeneric = dBServiceGeneric;
            _emailService = emailService;
            _shippingInfoList = GetAllShippingInfoAsync().Result;
        }

        public async Task<List<ShippingInfo>> GetAllShippingInfoAsync()
        {
            return (await _dBServiceGeneric.GetObjectsAsync()).ToList();
            //return JsonFileService.GetJsonObjects().ToList();
            //return MockData.MockDataConsultation.GetAllConsultations();
        }

        public async Task CreateShippingInfoAsync(ShippingInfo shippingInfo)
        {
            int IDCount = 0;
            //foreach (ShippingInfo listShippingInfo in ShippingInfoList)
            //{
            //    if (IDCount < listShippingInfo.ID)
            //    {
            //        IDCount = listShippingInfo.ID;
            //    }
            //}
            //shippingInfo.ID = IDCount + 1;
            _shippingInfoList.Add(shippingInfo);
            //_jsonFileService.SaveJsonObjects(ShippingInfoList);
            await _dBServiceGeneric.AddObjectAsync(shippingInfo);
        }

        public async Task<ShippingInfo> GetShippingByOrderIDAsync(int orderID)
        {
            using (var context = new ItemDbContext())
            {
                return await context.Set<ShippingInfo>()
                    .FirstOrDefaultAsync(shippingInfo => shippingInfo.OrderID == orderID);
            }
        }

        public async Task<ShippingInfo> GetShippingByIDAsync(int ID)
        {
            return await _dBServiceGeneric.GetObjectByIdAsync(ID);
        }

        public async Task DeleteShippingInfoByOrderIDAsync(int ID)
        {
            ShippingInfo shippingInfoToBeDelete = await GetShippingByOrderIDAsync(ID);
            if (shippingInfoToBeDelete != null)
            {
                _shippingInfoList.Remove(shippingInfoToBeDelete);
                //_jsonFileService.SaveJsonObjects(ShippingInfoList);
                await _dBServiceGeneric.DeleteObjectAsync(shippingInfoToBeDelete);
            }
        }

        public async Task UpdateShippingAsync(ShippingInfo shippingInfo)
        {
            ShippingInfo shippingInfoToBeUpdated = await GetShippingByIDAsync(shippingInfo.ID);
            if (shippingInfoToBeUpdated != null)
            {
                shippingInfoToBeUpdated.Address = shippingInfo.Address;
                shippingInfoToBeUpdated.City = shippingInfo.City;
                shippingInfoToBeUpdated.County = shippingInfo.County;
                shippingInfoToBeUpdated.PhoneNumber = shippingInfo.PhoneNumber;
                shippingInfoToBeUpdated.FirstName = shippingInfo.FirstName;
                shippingInfoToBeUpdated.LastName = shippingInfo.LastName;

                await _dBServiceGeneric.UpdateObjectAsync(shippingInfoToBeUpdated);
            }
        }

        public async Task SubmitShippingInfoByEmailAsync(ShippingInfo shippingInfo, string email)
        {
            ShippingInfo shippingInfoToBeSend = await GetShippingByIDAsync(shippingInfo.ID);

            if (shippingInfoToBeSend != null)
            {
                _emailService.SendEmail(new Email(shippingInfo.ToString(), $"Shipping for order: " + shippingInfo.OrderID + " " + email, email));
                // Becuase Jennie is getting spamed
                //_emailService.SendEmail(new Email(shippingInfo.ToString(), $"Shipping for order: " + shippingInfo.OrderID + " " + email, "chilterntalkingtherapies@gmail.com"));
            }
        }

    }
}
