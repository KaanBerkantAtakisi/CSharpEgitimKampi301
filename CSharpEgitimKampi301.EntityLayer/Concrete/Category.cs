using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }

        public List<Product> Products { get; set; }

    }
}

/*
Field-Variable-Property
 */

/* Eğer ki
 int x direkt olarak sınıfın içinde tanımlanırsa bu bi field'dır.
  int x; --> Field
Eğer ki classın içinde tanımlanan şey sonuna get ve set diye iki tane değer alırsa
bu bir property oluyor.
 Eğer ki değişken metod içinde tanımlanıyorsa bu kez değişken oluyor.
 
 */