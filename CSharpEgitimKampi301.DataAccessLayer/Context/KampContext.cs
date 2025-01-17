using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampi301.EntityLayer.Concrete;

namespace CSharpEgitimKampi301.DataAccessLayer.Context
{
    public class KampContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}

/*
 Bizim veritabanına yansıyacak olan bütün sınıflarımız bunun içinde yer alacak
yani bir sınıfı veritabanına yansıtmak istiyorsak tablo olarak onu mutlaka KampContext'in içine
yazmamız gerekiyor.
Yalın hali class olsun çoğul hali tablo olsun diyor  public DbSet<Category> Categories { get; set; } kısmında
Category ifadesi bizim C# tarafında kullanacak olduğumuz sınıfımızın ismi
Categories ise SQL'e yansıyacak olan tablo ismi. DbSet de bunun tablo olduğunu
uygulamaya bildirdiğim kısım.
 
 */