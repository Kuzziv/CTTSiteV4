using CTTSite.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System;
using CTTSite.DAO;
using CTTSite.Models.Forms;

namespace CTTSite.EFDbContext
{
    public class ItemDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CTTDB; Integrated Security=True; Connect Timeout=30; Encrypt=False");
        }   
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CartItem_Order> CartItem_Orders { get; set; }
        public DbSet<ShippingInfo> ShippingInfo { get; set; }
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<RoomBooking> RoomBookings { get; set; }
        public DbSet<FormActivityDiary> FormActivityDiaries { get; set; }
        public DbSet<FormActivityList> FormActivityLists { get; set; }
        public DbSet<FormActivitySchedule> FormActivitySchedules { get; set;}
        public DbSet<FormHotCrossBun> FormHotCrossBuns { get; set; }
        public DbSet<FormSleepDiary> FormSleepDiaries { get; set; }
    }
}
