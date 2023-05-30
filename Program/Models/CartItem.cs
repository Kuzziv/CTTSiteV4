using CTTSite.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTTSite.Models
{
    // Made by Mille & Mads
    public class CartItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int ItemID { get; set; }

        [Required]
        public Item Item { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public bool Paid { get; set; }


        public CartItem(int iD, int itemID, Item item, int quantity, int userID, User user, bool paid)
        {
            ID = iD;
            ItemID = itemID;
            Item = item;
            Quantity = quantity;
            UserID = userID;
            User = user;
            Paid = paid;
        }

        public CartItem()
        {
            
        }
    }
}
