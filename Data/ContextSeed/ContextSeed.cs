using Microsoft.AspNetCore.Identity;
using ShiftApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ShiftApp.Data.ContextSeed
{
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
            await roleManager.CreateAsync(new IdentityRole("Professional"));
            await roleManager.CreateAsync(new IdentityRole("Patient"));
        }
    }
}
