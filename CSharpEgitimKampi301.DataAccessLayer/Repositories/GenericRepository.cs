using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;

namespace CSharpEgitimKampi301.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        KampContext context = new KampContext();
         private readonly DbSet<T> _object; //bu bir field

        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        /* 17/20 arası
         Generic Repository classı çağırıldığı anda benim için objecte bir nesne örneği oluşturuyor ve
         buna geliyor Context sınıfından oluşturduğum entity'i atıyor.Buradaki entity değeri Admin olabilir,
         Product olabilir, Category olabilir vs . */

        public void Delete(T entity)
        {
            var deletedEntity= context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
            /* EntityState'te ekleme silme güncelleme ve başka bazı değişikliklere izin veren bir kod bloğu
             Bu kod bloğu komut sayesinde ben burada silme işlemini gerçekleştircem bu silme işlemi entityden gelen değere göre yapılacak.*/
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
            /* context.Entry(entity); bu ifadeyle biz ekleme işlemi yapacağımız Entity'yi hafızaya çektik*/
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;//Ekleme işlemini gerçekleştir
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State=EntityState.Modified;
            context.SaveChanges();
        }
    }
}
 