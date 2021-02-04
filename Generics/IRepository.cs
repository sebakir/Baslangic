using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public interface IRepository<T> where T : class, new() // Yazılacak parametra Class olmalı anlamına gelir  
        // sadece deger tii oymak istersek struct yazmalıydık
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
    }
}
