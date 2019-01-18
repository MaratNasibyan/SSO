using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OAuth.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        public string LastName { get; set; }
    }
}
