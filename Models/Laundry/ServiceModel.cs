using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Launchdry.Models
{
    public class ServiceModel : LaundryModel
    {
        [Required]
        public string Service { get; set; }
        [Required]
        public float Price { get; set; }

        public ServiceModel()
        {
            Service = "Baju, kemeja, dan celana per kilo"; //contoh
            Price = 10000;
        }

        public ServiceModel(string service, float price)
        {
            Service = service;
            Price = price;
        }
    }
}