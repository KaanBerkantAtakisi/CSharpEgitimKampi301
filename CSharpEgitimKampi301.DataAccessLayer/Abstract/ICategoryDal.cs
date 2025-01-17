using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampi301.EntityLayer.Concrete;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {

    }
}

/*
 ICategoryDal:IGenericDal<Category> 
şu ne anlama geliyor?
Artık ben Category Sınıfım için Ekleme,Silme,Güncelleme,Listeleme ve
Id'ye göre getirme işlemlerini hazır hale getirmiş oldum.Bu bu anlama geliyor.
 
 
 */