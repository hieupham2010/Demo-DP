using System;
using System.Collections.Generic;
using System.Text;

namespace AccessPatternCSharp
{
    public interface DAO<T>
    {
        public List<T> GetAll();
        public T GetById(int id);
        public void Create(T t);
        public void Update(T t);
        public void Delete(T t);
    }
}
