using System;
using System.ComponentModel.DataAnnotations;

namespace WEB315_Assignments_ThemeCricket.Models
{
    public class ThemeCricket
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Stadium Name is required.")]
        [StringLength(30, MinimumLength = 6)]
        [Display(Name ="Stadium Name")]
        public string StadiumName { get; set; }

        [Required(ErrorMessage = "Booking Date is required.")]
        [Display(Name ="Booking Date")]
        public DateTime BookingDate { get; set; }

        [Required(ErrorMessage = "Venue Name is required.")]
        [StringLength(30, MinimumLength = 6)]
        [Display(Name = "Located In City")]
        public string City { get; set; }

        [Required(ErrorMessage = "State Name is required.")]
        [StringLength(30, MinimumLength = 6)]
        public string State { get; set; }

        [Required(ErrorMessage = "Booking Price is required.")]
        [Range(1000, 5000)]
        [Display(Name = "Booking Price/Day in ($)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Seating Capacity is required.")]
        [Range(20000, 150000)]
        [Display(Name = "Seating Capacity")]
        public int Capacity { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "First letter should be uppercase, no special characters or numbers allowed")]
        [Required(ErrorMessage = "Match Entry is required.")]
        [StringLength(30, MinimumLength = 6)]
        [Display(Name = "Upcoming Matches")]
        public string FirstMatch { get; set; }

    }
}