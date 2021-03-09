using ForStudy.Business.Abstract.LangService;
using ForStudy.Data.Abstract.LangAbstract;
using ForStudy.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Business.Concrete.LangManager
{
    public class LangManager : ILangService
    {
        private readonly ILangRepo _langRepo;

        public LangManager(ILangRepo langRepo)
        {
            this._langRepo = langRepo;
        }

        public async Task Create(Lang lang)
        {
            await _langRepo.Create(lang);
        }

        public List<Lang> GetAll()
        {
            return _langRepo.GetAll();
        }

        public async Task<Lang> GetByCode(string code)
        {
            return await _langRepo.GetByCode(code);
        }

        public async Task<Lang> GetById(int id)
        {
            return await _langRepo.GetById(id);
        }

        public async Task Remove(Lang lang)
        {
            await _langRepo.Remove(lang);
        }

        public async Task Update(Lang lang)
        {
            await _langRepo.Update(lang);
        }
    }
}
