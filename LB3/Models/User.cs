using Microsoft.AspNetCore.Identity;
using System;

namespace Lb3.Models
{
    public class User : IdentityUser
    {
        public DateTime DateOfBirth { get; set; }
    }
}
