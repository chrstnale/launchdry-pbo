using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Launchdry.Models
{
    public class UserModel
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string NoTelp { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Address { get; set; }

        public UserModel()
        {
            ID = 0;
            Name = "Nama lengkap";
            UserName = "userName";
            Email = "launchdry@gmail.com";
            NoTelp = "0000000000000";
            Password = "password";
            Address = "address";
        }

        public UserModel(int id, string name, string userName, string email, string noTelp, string password, string address)
        {
            ID = id;
            Name = name;
            UserName = userName;
            Email = email;
            NoTelp = noTelp;
            Password = password;
            Address = address;
        }
    }

}