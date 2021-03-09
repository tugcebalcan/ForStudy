using ForStudy.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Data.Abstract.TagAbstract
{
    public interface ITagRepo : IGenericRepo<Tag>
    { 
        List<Tag> GetAll();
        Tag GetById(int id);
        List<Tag> GetTagsOrderDescending(int count);
    }
}
