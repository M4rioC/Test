using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaConcepto.Models
{
    public class User : IdentityUser
    {

        public string role { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
