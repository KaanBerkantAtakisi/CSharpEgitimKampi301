using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int ProductStock { get; set; }

        public decimal ProductPrice { get; set; }

        public string ProductDescription { get; set; }
        //Her bir ürünümüzün mutlaka bir kategorisi olmalı
        public int CategoryId { get; set; }

        //Bir ürünün kategori bilgisine ulaşmam için,kategori tablosunun değerlerine ürün üzerinden ulaşabilmem adına

        public virtual Category Category { get; set; }

        public List<Order> Orders { get; set; }

       // [NotMapped]
       // public string CategoryName { get; set; }

    }
}
