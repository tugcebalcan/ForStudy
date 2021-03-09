using ForStudy.Data.Abstract.SeoAbstract;
using ForStudy.Data.ApplicationDb;
using ForStudy.Data.Concrete.EF;
using ForStudy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForStudy.Data.Concrete.EfCore.SeoConcrete
{
    public class SeoRepo : EfCoreGenericRepo<Seo, ApplicationDbContext> , ISeoRepo
    {
        public List<Seo> GetAll()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Seos
                                   .Include(x=> x.SeoLangs)
                                        .ThenInclude(x => x.Lang)
                                   .ToList();
            }
        }

        public async Task<Seo> GetSeoIsBlog(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.Seos
                                         .Include(x => x.SeoLangs)
                                            .ThenInclude(x => x.Lang)
                                         .FirstOrDefaultAsync(x => x.UniqueId == id && x.IsBlog == true);
            }
        }

        public async Task<Seo> GetSeoIsProduct(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.Seos
                                         .Include(x => x.SeoLangs)
                                            .ThenInclude(x => x.Lang)
                                         .FirstOrDefaultAsync(x => x.UniqueId == id && x.IsProduct == true);
            }
        }
    }
}