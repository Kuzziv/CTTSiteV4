using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CTTSite.Models
{
    // Made by Mille
    public class RoomBooking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "A start date and time is required")]
        public DateTime StartDateTime { get; set; }

        [Required(ErrorMessage = "An end date and time is required")]
        public DateTime EndDateTime { get; set; }
        
        public string? Description { get; set; }


        public RoomBooking(int iD, string userEmail, DateTime startDateTime, DateTime endDateTime, string description)
        {
            ID = iD;
            UserEmail = userEmail;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            Description = description;
        }

        public RoomBooking()
        {
        }

    }
}
