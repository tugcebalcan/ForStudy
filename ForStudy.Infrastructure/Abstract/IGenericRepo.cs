using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Data.Abstract
{
    public interface IGenericRepo<T>
    {
        Task Create(T entity);
        Task Update(T entity);
        Task Remove(T entity);
    }
}
