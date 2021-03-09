using ForStudy.IdentityServer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.IdentityServer.Data
{
   public class ApplicationIdentityContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationIdentityContext(DbContextOptions<ApplicationIdentityContext> options) : base(options){ }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source =DESKTOP-H7362TJ\SQLEXPRESS; Database=Affilee; integrated security=true; User Id=sa; Password=160201070;");
        //}

        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
