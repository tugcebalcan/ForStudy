using ForStudy.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Business.Abstract.LangService
{
   public interface ILangService
    {
        Task<Lang> GetByCode(string code);
        List<Lang> GetAll();
        Task Create(Lang lang);
        Task<Lang> GetById(int id);
        Task Update(Lang lang);

        Task Remove(Lang lang);
    }
}
