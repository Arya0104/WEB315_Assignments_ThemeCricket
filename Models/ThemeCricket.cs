using System;
using System.ComponentModel.DataAnnotations;

namespace WEB315_Assignments_ThemeCricket.Models
{
    public class ThemeCricket
    {
        public int ID { get; set; }
        public string StadiumName { get; set; }
        public DateTime BookingDate { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Price { get; set; }

    }
}