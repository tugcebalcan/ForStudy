using ForStudy.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForStudy.Data.Abstract.LangAbstract
{
    public interface ILangRepo : IGenericRepo<Lang>
    {
        Task<Lang> GetByCode(string code);
        List<Lang> GetAll();
        Task<Lang> GetById(int id);
    }
}