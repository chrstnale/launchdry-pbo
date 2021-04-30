using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Launchdry.Models
{
    public class LaundryModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public float Longitude { get; set; }
        [Required]
        public float Latitude { get; set; }
        [Required]
        public string Address { get; set; }

        public LaundryModel()
        {
            Name = "Nama Laundry";
            Longitude = 0;
            Latitude = 0;
            Address = "alamat";
        }

        public LaundryModel(string name, float longitude, float latitude, string address)
        {
            Name = name;
            Longitude = longitude;
            Latitude = latitude;
            Address = address;
        }
    }
}