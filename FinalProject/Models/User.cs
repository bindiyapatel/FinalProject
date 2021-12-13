using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
namespace FinalProject.Models
{
    public class User
    {

        public int UserId { get; set; }
        [DisplayName("Name")]
        public string? Name { get; set; }
        [DisplayName("User Name")]
        public string? Username { get; set; }
        [DisplayName("Password")]
        public string? Password { get; set; }
        public string? IsActive { get; set; }
    }
}
