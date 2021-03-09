using ForStudy.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Data.Abstract.TagAbstract
{
    public interface ITagLangRepo : IGenericRepo<TagLang>
    {
        List<TagLang> GetAllIsActive();

        Task<TagLang> GetById(int id);
        Task<List<TagLang>> GetByTag(int id);

        List<TagLang> GetAll();
    }
}
