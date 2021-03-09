using ForStudy.IdentityServer.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.IdentityServer.Data
{
   public static class SeedIdentity
    {
        public static async Task Seed(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var username = "aaaaa";
            var email = "aaaaa@aaaaa";
            var password = "aaaa";
            var role = "admin";
            var fullname = "admin";

            if (await userManager.FindByNameAsync(username) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(role));

                var user = new ApplicationUser()
                {
                    UserName = username,
                    RoleName = role,
                    Email = email,
                    FullName = fullname,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, role);
                }
            }
        }
    }
}
