using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Khanar_Dokan_API.Repository
{
    interface iRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Delete(int id);
        void Edit(T entity);
    }
}