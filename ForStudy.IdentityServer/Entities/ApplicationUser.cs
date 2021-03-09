using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.IdentityServer.Entities
{
   public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string RoleName { get; set; }
    
    }
}
