using ForStudy.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForStudy.Data.Abstract.SeoAbstract
{
    public interface ISeoRepo : IGenericRepo<Seo>
    {
        List<Seo> GetAll();
        Task<Seo> GetSeoIsBlog(int id);
        Task<Seo> GetSeoIsProduct(int id);
    }
}