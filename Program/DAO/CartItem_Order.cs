using CTTSite.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTTSite.DAO
{
    // Made by Mille & Mads
    public class CartItem_Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CartItemID { get; set; }
        public int OrderID { get; set; }

        public CartItem_Order(int cartItemID, int orderID)
        {
            CartItemID = cartItemID;
            OrderID = orderID;
        }

        public CartItem_Order()
        {
        }
    }
}
