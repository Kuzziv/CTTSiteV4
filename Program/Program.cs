using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CTTSite.Services.NormalService;
using CTTSite.Services.JSON;
using CTTSite.Services.Interface;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CTTSite.Models;
using CTTSite.Services;
using CTTSite.EFDbContext;
using CTTSite.Services.DB;
using CTTSite.Models.Forms;
using CTTSite.DAO;
using CTTSite.Services.MockDataService;


// Edited by Christian

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//MockData
builder.Services.AddSingleton<MockDataConsultationService, MockDataConsultationService>();

builder.Services.AddSingleton<IItemService, ItemService>();
builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddSingleton<ICartItemService, CartItemService>();
builder.Services.AddSingleton<IShippingInfoService, ShippingInfoService>();
builder.Services.AddSingleton<IOrderService, OrderService>();
builder.Services.AddSingleton<IFormService, FormService>();
builder.Services.AddSingleton<IConsultationService, ConsultationService>();
builder.Services.AddSingleton<IRoomBookingService, RoomBookingService>();
builder.Services.AddTransient<JsonFileService<User>>();
builder.Services.AddTransient<JsonFileService<Item>>();
builder.Services.AddTransient<JsonFileService<CartItem>>();
builder.Services.AddTransient<JsonFileService<ShippingInfo>>();
builder.Services.AddTransient<JsonFileService<Order>>();
builder.Services.AddTransient<JsonFileService<Consultation>>();
builder.Services.AddDbContext<ItemDbContext>();
builder.Services.AddTransient<DBServiceGeneric<Item>>();
builder.Services.AddTransient<DBServiceGeneric<CartItem>>();
builder.Services.AddTransient<DBServiceGeneric<User>>();
builder.Services.AddTransient<DBServiceGeneric<Order>>();
builder.Services.AddTransient<DBServiceGeneric<ShippingInfo>>();
builder.Services.AddTransient<DBServiceGeneric<Consultation>>();
builder.Services.AddTransient<DBServiceGeneric<RoomBooking>>();
builder.Services.AddTransient<DBServiceGeneric<CartItem_Order>>();
builder.Services.AddTransient<DBServiceGeneric<FormActivityDiary>>();
builder.Services.AddTransient<DBServiceGeneric<FormActivityList>>();
builder.Services.AddTransient<DBServiceGeneric<FormActivitySchedule>>();
builder.Services.AddTransient<DBServiceGeneric<FormHotCrossBun>>();
builder.Services.AddTransient<DBServiceGeneric<FormSleepDiary>>();
builder.Services.AddSingleton<IEmailService, EmailService>();


builder.Services.Configure<CookiePolicyOptions>(options => {
    // This lambda determines whether user consent for non-essential cookies is needed for a given request. options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;

});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(cookieOptions => {
    cookieOptions.LoginPath = "/User/Login/LogInPage";

});
builder.Services.AddMvc().AddRazorPagesOptions(options =>
{
    options.Conventions.AuthorizeFolder("/Admin");

}).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
