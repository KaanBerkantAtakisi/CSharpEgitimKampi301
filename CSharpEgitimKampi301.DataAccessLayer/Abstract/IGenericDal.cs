using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

        List<T> GetAll();

        T GetById(int id);

    }
}
/*
 Buradaki T değeri sırasıyla bizim bütün Entitylerimiz olacak
 Mesela önce Category olacak sonra Customer olacak sonra Order olacak
sonra Product olacak vs. şeklinde gidiyor.
 */