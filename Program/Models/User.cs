using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTTSite.Models
{
    // Made by Christian
    public class User
    {
        

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        
        [Display(Name = "Email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, MinimumLength = 5)]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        [StringLength(200, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        public bool Admin { get; set; }

        [Required]
        public bool Staff { get; set; }



        public User()
        {
            
        }

        public User(string email, string password, bool admin, bool staff)
        {
                     
            Email = email;
            Password = password;
            Admin = admin;
            Staff = staff;
        }
    }
}
