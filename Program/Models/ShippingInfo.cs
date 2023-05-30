using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CTTSite.Models
{
    // Made by Mille & Mads
    public class ShippingInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public int OrderID { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string PostCode { get; set; }

        [Required]
        public string County { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime SubmissionDate { get; set; }


        public ShippingInfo(int userID, int orderID, string address, string city, string postCode, string county, string phoneNumber, string firstName, string lastName, DateTime submissionDate)
        {
            UserID = userID;
            OrderID = orderID;
            Address = address;
            City = city;
            PostCode = postCode;
            County = county;
            PhoneNumber = phoneNumber;
            FirstName = firstName;
            LastName = lastName;
            SubmissionDate = submissionDate;
        }

        public ShippingInfo()
        {
            
        }

        public override string ToString()
        {
            return 
                "Order number: " + OrderID + "\n" +
                "Address: " + Address + "\n" +
                "City: " + City + "\n" +
                "PostCode: " + PostCode + "\n" +
                "County: " + County + "\n" +
                "PhoneNumber: " + PhoneNumber + "\n" +
                "FirstName: " + FirstName + "\n" +
                "LastName: " + LastName + "\n" +
                "SubmissionDate: " + SubmissionDate + "\n";
        }
    }
}
