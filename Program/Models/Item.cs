using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTTSite.Models
{
    // Made by Mille & Mads
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Image is required if you there is no Image then type NoImg")]
        [StringLength(100)]
        public string IMG { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Stock is required")]
        public int Stock { get; set; }

        public Item(int id, string name, string description, string img, decimal price, int stock)
        {
            ID = id;
            Name = name;
            Description = description;
            IMG = img;
            Price = price;
            Stock = stock;
        }

        public Item()
        {
        }
    }
}
