using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CTTSite.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public bool Shipped { get; set; }

        [Required]
        public bool Cancelled { get; set; }

        public Order(int iD, int userID, decimal totalPrice, bool shipped, bool cancelled)
        {
            ID=iD;
            UserID=userID;
            TotalPrice=totalPrice;
            Shipped=shipped;
            Cancelled=cancelled;
        }

        public Order()
        {
            
        }

        public override string ToString()
        {
            return
                "ID: " + ID + "\n";
        }
    }
}
