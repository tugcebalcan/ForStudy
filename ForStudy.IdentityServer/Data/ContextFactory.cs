using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ForStudy.IdentityServer.Data
{
    public class ContextFactory : IDesignTimeDbContextFactory<ApplicationIdentityContext>
    {
        public ApplicationIdentityContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationIdentityContext>();
            optionsBuilder.UseSqlServer(@"Data Source =.; Integrated Security = True; Initial Catalog=FP;");
            
            return new ApplicationIdentityContext(optionsBuilder.Options);
        }
    }

}