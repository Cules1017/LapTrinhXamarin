using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Models
{
    public class City
    {
        [PrimaryKey, AutoIncrement] 
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string CityImageUrl { get; set; }
    }
}
