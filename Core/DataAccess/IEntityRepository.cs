using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //*******************Farlı katmanlardan implement almaz
    //generic contraint --> generic kısıtlama
    //class : referans tip olabilir demek ,IEntity olabilir veya IEntity implement edenler olabilir.
    //new() : new'lenemez olmalı.--> IEntity yi devre dışı bıraktık,soyut diye.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
 
    }
}
