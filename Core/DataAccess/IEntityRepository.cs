using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccsess
{
    // where T : T bir referans tip olacak, IEntity veya referansı olacak, newlenebilir olacak(Bu sayede IEntity'in referanslarını seçiyoruz IEntity'in kendisi newlenemediğinden o seçilmiyor bu şekilde...)

    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
