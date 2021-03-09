using ForStudy.Data.Abstract.LangAbstract;
using ForStudy.Data.ApplicationDb;
using ForStudy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForStudy.Data.Concrete.EfCore.LangConcrete
{
    public class LangRepo : EfCoreGenericRepo<Lang, ApplicationDbContext>, ILangRepo
    {
        public List<Lang> GetAll()
        {
            using (var context = new ApplicationDbContext())
            {
                List<Lang> model = new List<Lang>();
                var model2 =  context.Langs.ToList();
                if (model2 != null) model = model2;

               return model;
            }
        }

        public async Task<Lang> GetByCode(string code)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.Langs.FirstOrDefaultAsync(x => x.IsActive == true && x.Code.ToLower() == code);
            }
        }

        public async Task<Lang> GetById(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.Langs.FirstOrDefaultAsync(x => x.Id == id);
            }
        }
    }
}