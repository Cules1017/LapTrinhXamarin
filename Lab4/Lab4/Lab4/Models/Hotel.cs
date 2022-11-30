using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Models
{
    public class Hotel
    {
        [PrimaryKey, AutoIncrement]
        public int HotelId { get; set; }
        public string CityName { get; set; }
        public string HotelName { get; set; }
        public string HotelImageUrl { get; set; }
    }
}
