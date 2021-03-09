using ForStudy.Data.Abstract.SeoAbstract;
using ForStudy.Data.ApplicationDb;
using ForStudy.Data.Concrete.EF;
using ForStudy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Threading.Tasks;

namespace ForStudy.Data.Concrete.EfCore.SeoConcrete
{
    public class SeoLangRepo : EfCoreGenericRepo<SeoLang, ApplicationDbContext>, ISeoLangRepo
    {
    }
}